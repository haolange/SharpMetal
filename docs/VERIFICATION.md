# Verification

Commands run from this repository with .NET SDK 10. All gates are TODO(UNVERIFIED) until an explicit result is recorded. Native execution requires macOS ARM64; Windows validates only the managed ABI and independent consumer build.

```powershell
dotnet build src/SharpMetal/SharpMetal.csproj -c Debug
dotnet build src/SharpMetal/SharpMetal.csproj -c Release
dotnet run --project samples/SharpMetal.Sample/SharpMetal.Sample.csproj -c Release -p:StackReferenceMode=Source
dotnet pack src/SharpMetal/SharpMetal.csproj -c Release -o artifacts/packages
```

The sample reports BLOCKED_PLATFORM on a non-Apple host; that is not native qualification. On macOS ARM64 it must create a device and shared buffer, validate memory and dispose owners. Further backend conformance is owned by SharpGPU.
