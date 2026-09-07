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
and update the consuming workspace revision manifest after the final commit. Any source or package
change invalidates the corresponding evidence.

Source handoff records this repository HEAD and every mapped dependency HEAD in
the consuming workspace manifest. IE uses its root stack.lock.json; standalone
consumers own their manifest and do not need an IE checkout. Package consumers
use the project dependency versions and NuGet lock files. There is no product-local
stack.lock.json: the removed copies were not read by any build or setup tool.

## Automated Windows managed gate

`eng/Verify.ps1` is the product-local CI entry point. The workflow runs both
configurations, uses locked Source restores, builds the library, runs owned
CPU tests when present, and packs locally. It copies the real sample into an
isolated consumer with an empty package cache and only the freshly built feed,
rejects project dependencies, then executes the binary from another directory.
It refuses an existing evidence directory. Packages are not uploaded or released.

```powershell
./eng/Verify.ps1 -Configuration Debug -OutputRoot "$env:TEMP/product-debug-validation"
./eng/Verify.ps1 -Configuration Release -OutputRoot "$env:TEMP/product-release-validation"
```

This gate is Windows x64 managed/package evidence, not GPU or Apple native
qualification. GitHub execution remains TODO(UNVERIFIED) until the workflow
runs remotely. Locked Source restore must remain green after the pending
Source/Package lock-file migration; CI must not regenerate tracked locks to
conceal mismatches. Local results and package SHA-256 are in `result.json`,
with full commands/output in `verification.log` and applicable TRX in `results`.

The current native-output capture implementation was rerun in Debug and Release
on Windows. Both passed; full sample stdout is present in verification.log.
Evidence directories: `D:/Projects/InfinityStackVerification/ci-logged-<product>-<configuration>`.
Math owned tests: 29/29 per configuration; LLM owned tests: 30/30 per configuration;
Metal has no test project and records only managed ABI/sample qualification.
These are local working-tree results; remote CI remains TODO(UNVERIFIED).
