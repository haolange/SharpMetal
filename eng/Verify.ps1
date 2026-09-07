[CmdletBinding()]
param(
    [ValidateSet('Debug', 'Release')][string]$Configuration = 'Release',
    [Parameter(Mandatory)][string]$OutputRoot
)
$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
if (-not $IsWindows) { throw 'This gate qualifies Windows x64; use the documented matching-host gates on other platforms.' }
$product = 'SharpMetal'
$root = Split-Path $PSScriptRoot -Parent
$output = [IO.Path]::GetFullPath($OutputRoot)
if (Test-Path -LiteralPath $output) { throw "Evidence directory already exists: $output" }
New-Item -ItemType Directory -Path $output | Out-Null
function Invoke-DotNet([string[]]$Arguments)
{
    Write-Host ("dotnet " + ($Arguments -join " "))
    & dotnet @Arguments 2>&1 | ForEach-Object { Write-Host $_ }
    if ($LASTEXITCODE -ne 0) { throw "dotnet $($Arguments -join ' ') failed: $LASTEXITCODE" }
}
Start-Transcript -Path (Join-Path $output 'verification.log') | Out-Null
try
{
    $mapping = Join-Path $output 'stack.local.props'
    '<Project />' | Set-Content -LiteralPath $mapping -Encoding utf8
    $properties = @('-p:StackReferenceMode=Source', '-p:Platform=x64',
        "-p:StackLocalProps=$mapping", "-p:StackProductRoot=$output/products",
        '-p:RestoreUseStaticGraphEvaluation=false', '-m:1', '-nr:false')
    $library = Join-Path $root "src/$product/$product.csproj"
    Invoke-DotNet (@('restore', $library, '--locked-mode', "-p:Configuration=$Configuration") + $properties)
    Invoke-DotNet (@('build', $library, '-c', $Configuration, '--no-restore') + $properties)
    $test = Join-Path $root "tests/$product.Tests/$product.Tests.csproj"
    if (Test-Path -LiteralPath $test)
    {
        Invoke-DotNet (@('restore', $test, '--locked-mode', "-p:Configuration=$Configuration") + $properties)
        Invoke-DotNet (@('test', $test, '-c', $Configuration, '--no-restore', '--logger', 'trx',
            '--results-directory', "$output/results") + $properties)
    }
    Invoke-DotNet (@('pack', $library, '-c', $Configuration, '--no-build', '-o', "$output/feed") + $properties)
    $packages = @(Get-ChildItem -LiteralPath "$output/feed" -Filter "$product.*.nupkg")
    if ($packages.Count -ne 1) { throw 'Expected exactly one freshly built product package.' }
    $version = $packages[0].Name.Substring($product.Length + 1) -replace '\.nupkg$', ''
    $consumer = Join-Path $output 'isolated consumer'
    New-Item -ItemType Directory -Path $consumer | Out-Null
    Copy-Item -LiteralPath (Join-Path $root "samples/$product.Sample/Program.cs") -Destination $consumer
    '<Project />' | Set-Content -LiteralPath "$consumer/Directory.Build.props" -Encoding utf8
    '<Project />' | Set-Content -LiteralPath "$consumer/Directory.Build.targets" -Encoding utf8
    "<Project Sdk=`"Microsoft.NET.Sdk`"><PropertyGroup><OutputType>Exe</OutputType><TargetFramework>net10.0</TargetFramework><AllowUnsafeBlocks>true</AllowUnsafeBlocks></PropertyGroup><ItemGroup><PackageReference Include=`"$product`" Version=`"$version`" /></ItemGroup></Project>" |
        Set-Content -LiteralPath "$consumer/Consumer.csproj" -Encoding utf8
    $feed = [Security.SecurityElement]::Escape("$output/feed")
    "<configuration><packageSources><clear/><add key=`"fresh`" value=`"$feed`"/></packageSources><fallbackPackageFolders><clear/></fallbackPackageFolders></configuration>" |
        Set-Content -LiteralPath "$consumer/NuGet.Config" -Encoding utf8
    Invoke-DotNet @('restore', "$consumer/Consumer.csproj", '--configfile', "$consumer/NuGet.Config", '--packages', "$output/package-cache")
    Invoke-DotNet @('build', "$consumer/Consumer.csproj", '-c', $Configuration, '--no-restore')
    $assets = Get-Content -Raw -LiteralPath "$consumer/obj/project.assets.json" | ConvertFrom-Json
    if (@($assets.libraries.PSObject.Properties | Where-Object { $_.Value.type -eq 'project' }).Count -ne 0)
    { throw 'Isolated package consumer unexpectedly contains source project dependencies.' }
    Push-Location ([IO.Path]::GetTempPath())
    try { Invoke-DotNet @("$consumer/bin/$Configuration/net10.0/Consumer.dll") }
    finally { Pop-Location }
    [ordered]@{
        product = $product; configuration = $Configuration; managedBuildAndPackageConsumer = 'PASS'
        nativeMetal = $(if ($product -eq 'SharpMetal') { 'BLOCKED_PLATFORM: Windows managed gate only' } else { 'NOT_APPLICABLE' })
        packageSha256 = (Get-FileHash -LiteralPath $packages[0].FullName -Algorithm SHA256).Hash
    } | ConvertTo-Json | Set-Content -LiteralPath "$output/result.json" -Encoding utf8
}
finally { Stop-Transcript | Out-Null }
