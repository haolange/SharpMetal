---
kind: build_system
name: 基于 MSBuild 全局属性与 Source/Package 双模式的 .NET 10 构建编排
category: build_system
scope:
    - '**'
source_files:
    - Directory.Build.props
    - Directory.Build.targets
    - SharpMetal.product.props
    - global.json
    - src/SharpMetal/SharpMetal.csproj
    - samples/SharpMetal.Sample/SharpMetal.Sample.csproj
    - .github/workflows/verify.yml
    - eng/Verify.ps1
---

## 1. 使用的系统与工具

- **MSBuild + .NET SDK 10**：通过 `global.json` 锁定 SDK 版本为 `10.0.100`（rollForward=latestFeature，禁止预发行），所有项目均使用 `Microsoft.NET.Sdk`。
- **GitHub Actions**：`.github/workflows/verify.yml` 在 `windows-latest` 上对 Debug/Release 两个配置执行构建、测试与包验证。
- **PowerShell 编排脚本**：`eng/Verify.ps1` 是单一入口，串联 restore → build → test → pack → 隔离消费者验证。
- **NuGet 锁文件**：启用 `RestoreUseStaticGraphEvaluation=true` 并通过 `--locked-mode` 强制依赖锁定；每个项目提供 `packages.Package.portable.lock.json` 与 `packages.Source.portable.lock.json` 两份锁文件。

## 2. 关键文件与位置

| 文件 | 作用 |
|---|---|
| `Directory.Build.props` | 根级 MSBuild 全局属性：定义输出目录、平台、Configuration/Platform/RID 默认值、锁文件路径、Deterministic、CI 标志等 |
| `Directory.Build.targets` | 根级目标：传递 ProjectReference 的 Stack 属性、校验 `StackReferenceMode`、阻止 Source/Package 混用 |
| `SharpMetal.product.props` | 产品名 `SharpMetal` 声明，被 `Directory.Build.props` 统一 Import |
| `src/SharpMetal/SharpMetal.csproj` | 库工程：TargetFramework=`net10.0`，Platforms=`x64;ARM64`，Version 取自 `$(StackPackageVersion)` |
| `samples/SharpMetal.Sample/SharpMetal.Sample.csproj` | 示例工程：按 `StackReferenceMode` 条件切换 `ProjectReference` 与 `PackageReference` |
| `.github/workflows/verify.yml` | CI 工作流：矩阵化 Debug/Release，调用 `eng/Verify.ps1` |
| `eng/Verify.ps1` | 构建编排：Source 模式恢复/构建/测试/打包，再创建隔离 NuGet feed 消费刚产出的 nupkg |
| `stack.local.props.example` | 本地开发映射模板（用于 Source 模式下指向上游仓库 checkout） |

## 3. 架构与约定

### 3.1 统一的输出布局
所有中间产物与二进制统一输出到 `artifacts/bin/<ProjectName>/<ReferenceMode>/<Platform>/<RID>/`，obj 对应 `artifacts/obj/...`。RID 默认 `portable`，可通过 `RuntimeIdentifier` 覆盖。`DefaultItemExcludes` 排除 `artifacts/**`、`bin/**`、`obj/**`，避免污染源码树。

### 3.2 Source / Package 双参考模式
- `StackReferenceMode` 仅允许 `Source` 或 `Package`（由 `Directory.Build.targets` 中的 `ValidateStackReferenceMode` 目标强制校验，否则直接报错）。
- 当 `StackReferenceMode=Source` 时，示例工程通过 `<ProjectReference Include="../../src/SharpMetal/SharpMetal.csproj" />` 引用源码；同时要求 `stack.local.props` 中配置 `SharpMetalRoot` 指向该产品的本地 checkout，并存在 `SharpMetal.product.props`，否则构建失败。
- 当 `StackReferenceMode=Package` 时，示例工程通过 `<PackageReference Include="SharpMetal" Version="$(StackPackageVersion)" />` 引用已发布包。
- 在 Source 模式下，若项目中仍包含 `SharpMath/Metal/GPU/Shader/Neural/LLM` 开头的 `PackageReference`，会触发冲突错误，强制“整个产品图必须一致选择 Source 或 Package”。

### 3.3 版本与可重现性
- 版本号集中来自 `Directory.Build.props` 中的 `StackPackageVersion`（当前 `0.4.0-preview.1`），库工程通过 `<Version>$(StackPackageVersion)</Version>` 继承。
- 开启 `<Deterministic>true</Deterministic>` 与 `ContinuousIntegrationBuild`（当环境变量 `CI=true` 时），保证 CI 下可重现构建。
- 包元数据（PackageId、Description、License、Readme）集中在 `src/SharpMetal/SharpMetal.csproj` 中。

### 3.4 平台与运行时
- 库工程显式声明 `<Platforms>x64;ARM64</Platforms>`，Debug 配置打开 full debug symbols，Release 开启优化。
- 示例工程不指定 Platform，由 MSBuild 根据引用链推导；CI 中通过 `-p:Platform=x64` 固定。

### 3.5 验证流水线（CI 与本地）
`eng/Verify.ps1` 执行顺序：
1. 强制运行环境为 Windows（非 Windows 抛错）。
2. 以 `StackReferenceMode=Source`、`Platform=x64`、`RestoreUseStaticGraphEvaluation=false`、`-m:1 -nr:false` 参数恢复并构建 `src/SharpMetal/SharpMetal.csproj`。
3. 若存在 `tests/SharpMetal.Tests` 则恢复并执行 `dotnet test`，结果写入 TRX 到 `results/`。
4. 执行 `dotnet pack` 产出 nupkg 到 `feed/`，断言恰好一个包。
5. 在临时目录创建“隔离消费者”：复制 `samples/SharpMetal.Sample/Program.cs`，生成最小 `Consumer.csproj` 引用刚产出的包版本，并配置本地 NuGet.Config 仅指向该 `feed/`。
6. 恢复并构建消费者，断言其 `project.assets.json` 不包含任何 `type='project'` 的依赖（确保包内无残留源码引用）。
7. 运行消费者 DLL 完成端到端验证。
8. 输出 `result.json`，包含 `packageSha256` 供下游比对。

## 4. 约定与约束

| 规则 | 来源/实现方式 |
|---|---|
| 所有项目必须通过 `Directory.Build.props` 接受统一输出路径、RID、锁文件路径 | 根级 props 强制设置 `BaseOutputPath`、`BaseIntermediateOutputPath`、`NuGetLockFilePath` |
| `StackReferenceMode` 只能取 `Source` 或 `Package` | `Directory.Build.targets` 中 `ValidateStackReferenceMode` 目标报错 |
| Source 模式下不得混入 Sharp* 系列 `PackageReference` | 同一目标正则匹配并报错 |
| Source 模式必须提供 `SharpMetalRoot` 且目标 checkout 存在 `SharpMetal.product.props` 与项目文件 | 同一目标逐项检查并报错 |
| 依赖必须通过锁文件恢复，禁止动态解析 | `RestoreUseStaticGraphEvaluation=true` + `--locked-mode` |
| CI 下构建必须可重现 | `Deterministic=true` + `ContinuousIntegrationBuild`（CI=true 时） |
| 示例工程必须以与最终用户完全相同的方式消费产物 | `eng/Verify.ps1` 在隔离目录重建消费者并断言无 project 类型依赖 |
| 仅 Windows x64 受此 gate 覆盖 | `eng/Verify.ps1` 开头 `if (-not $IsWindows) throw ...` |
| 包版本统一来源于 `StackPackageVersion` | `src/SharpMetal/SharpMetal.csproj` 中 `<Version>$(StackPackageVersion)</Version>` |
