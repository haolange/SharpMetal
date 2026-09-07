# SharpMetal verification

Run these gates from the SharpMetal repository with the .NET 10 SDK. The
managed bindings are independent of the host platform; native Metal execution
requires a matching Apple host and system frameworks.

```powershell
$productRoot = Join-Path $PWD "artifacts/verification-r12"
$sourceProps = @(
    "-p:StackReferenceMode=Source",
    "-p:StackProductRoot=$productRoot",
    "-p:StackLocalProps=$(Join-Path $PWD 'stack.local.props')",
    "-p:RestoreUseStaticGraphEvaluation=false",
    "-p:NuGetAudit=false"
)

dotnet build src/SharpMetal/SharpMetal.csproj -c Debug -p:Platform=x64 @sourceProps
dotnet build src/SharpMetal/SharpMetal.csproj -c Release -p:Platform=x64 @sourceProps
$env:INFINITYSTACK_SHARPMETAL_ROOT = $PWD.Path
dotnet run --project samples/SharpMetal.Sample/SharpMetal.Sample.csproj -c Release -p:Platform=x64 @sourceProps
dotnet pack src/SharpMetal/SharpMetal.csproj -c Release -p:Platform=x64 -o artifacts/verification-r12/packages @sourceProps
```

The Windows x64 source builds complete with zero warnings and errors. The
Release sample reports `Managed ABI passed` and explicitly returns
`BLOCKED_PLATFORM (Apple host required)` for its native workload. The package
is `artifacts/verification-r12/packages-release-final/SharpMetal.0.4.0-preview.1.nupkg`.

The package sample uses the isolated
`D:/Projects/InfinityStack/.verification/package-cache-math-metal-final` cache
and the local package feed:

```powershell
$cache = "D:/Projects/InfinityStack/.verification/package-cache-math-metal-final"
$packageProps = @(
    "-p:Configuration=Release", "-p:Platform=x64",
    "-p:StackReferenceMode=Package",
    "-p:StackProductRoot=$(Join-Path $PWD 'artifacts/verification-r12')",
    "-p:StackLocalProps=$(Join-Path $PWD 'stack.local.props')",
    "-p:RestorePackagesPath=$cache", "-p:NuGetPackageRoot=$cache",
    "-p:RestoreUseStaticGraphEvaluation=false", "-p:NuGetAudit=false",
    "-p:RestoreIgnoreFailedSources=true", "-p:RestoreForceEvaluate=true"
)
dotnet run --project samples/SharpMetal.Sample/SharpMetal.Sample.csproj @packageProps --source artifacts/verification-r12/packages-release-final
```

The isolated package sample produces the same managed ABI result and the same
explicit Apple-host boundary. The evidence is
`artifacts/verification-r12/sample-package-final-r2.log`.

On macOS ARM64, run the Release source and package samples on a machine with
Metal system frameworks, then verify device creation, shared-buffer mapping,
resource ownership, and disposal. Until that matching host run is available,
Apple native qualification remains `BLOCKED_PLATFORM`; Linux, Android, and iOS
native qualification remains `TODO(UNVERIFIED)`. SharpGPU owns the RHI and
cross-backend qualification. Before accepting a revision, run `git diff --check`
and update `stack.lock.json` after the final commit. Any source or package
change invalidates the corresponding evidence.
