---
kind: dependency_management
name: 基于 MSBuild + NuGet 锁文件的 Source/Package 双模式依赖管理
category: dependency_management
scope:
    - '**'
source_files:
    - global.json
    - Directory.Build.props
    - Directory.Build.targets
    - src/SharpMetal/SharpMetal.csproj
    - samples/SharpMetal.Sample/SharpMetal.Sample.csproj
    - src/SharpMetal/packages.Package.portable.lock.json
    - src/SharpMetal/packages.Source.portable.lock.json
    - samples/SharpMetal.Sample/packages.Package.portable.lock.json
    - samples/SharpMetal.Sample/packages.Source.portable.lock.json
---

## 1. 使用的系统与方法

本仓库是一个纯 .NET（C#）项目，使用 **NuGet** 作为包管理器，通过 **MSBuild 全局属性** 与 **`global.json`** 锁定 SDK 版本（`10.0.100`，`rollForward=latestFeature`，禁止预发行版），实现跨机器一致的依赖解析。

核心策略是 **Source / Package 双参考模式**：同一份工程文件同时支持以 `ProjectReference` 引用本地源码，或以 `PackageReference` 引用已发布的 NuGet 包，由构建时变量 `StackReferenceMode` 切换。该模式在 `Directory.Build.targets` 中通过 `ValidateStackReferenceMode` Target 强制校验，只允许 `Source` 或 `Package` 两种取值。

## 2. 关键文件

- `global.json`：锁定 .NET SDK 版本为 `10.0.100`。
- `Directory.Build.props`：定义全局构建属性，包括 `StackReferenceMode`（默认 `Package`）、`StackPackageVersion`（`0.4.0-preview.1`）、确定性输出、以及最重要的 **NuGet 锁文件路径约定**：
  - `RestorePackagesWithLockFile=true`
  - `NuGetLockFilePath` 指向 `packages.$(StackReferenceMode).portable.lock.json`，即每个项目目录下存在两份锁文件。
- `Directory.Build.targets`：集中编排依赖验证逻辑，包括 Source/Package 模式互斥检查、源引用映射校验、以及与 SharpGPU 的 transitive 目标导入。
- `src/SharpMetal/SharpMetal.csproj`：库项目，声明 `TargetFramework=net10.0`、`Platforms=x64;ARM64`、`AllowUnsafeBlocks`，并通过 `Version=$(StackPackageVersion)` 继承产品版本号。
- `samples/SharpMetal.Sample/SharpMetal.Sample.csproj`：示例应用，用条件 ItemGroup 根据 `StackReferenceMode` 选择 `ProjectReference` 或 `PackageReference Include="SharpMetal" Version="$(StackPackageVersion)"`。
- `src/SharpMetal/packages.Package.portable.lock.json` 与 `packages.Source.portable.lock.json`：分别对应两种模式的 NuGet 锁文件（当前无第三方依赖，仅记录 net10.0 框架）。
- `samples/SharpMetal.Sample/packages.*.lock.json`：示例项目的锁文件，Package 模式下锁定 `SharpMetal@0.4.0-preview.1`，Source 模式下标记为 `type=Project`。
- `stack.local.props.example`：提供本地开发覆盖配置模板（被 `Directory.Build.props` 有条件 Import）。

## 3. 架构与约定

### 3.1 隔离输出目录
所有中间产物与二进制统一输出到根目录下的 `artifacts/bin/<ProjectName>/<StackReferenceMode>/<Platform>/<RuntimeIdentifier>/`，避免源码树污染，也便于区分 Source 与 Package 两种构建结果。

### 3.2 双锁文件机制
每个项目目录下同时维护两份 lock 文件：
- `packages.Package.portable.lock.json`：发布/消费 NuGet 包时的精确依赖快照。
- `packages.Source.portable.lock.json`：本地源码联调时的依赖快照。
构建时通过 `NuGetLockFilePath` 动态选择，确保 Source 与 Package 两种模式各自可独立还原且互不干扰。

### 3.3 Source 模式下的上游栈集成
`Directory.Build.targets` 中的 `ValidateStackReferenceMode` Target 在 `CollectPackageReferences` 之前执行，会：
- 校验 `StackReferenceMode` 必须为 `Source` 或 `Package`；
- 当启用 Source 模式时，禁止出现匹配 `Sharp(Math|Metal|GPU|Shader|Neural|LLM)` 命名空间的 `PackageReference`，防止“部分源码、部分包”的混合引用；
- 要求通过 `stack.local.props` 配置 `SharpGPURoot` 等上游栈产品的 checkout 路径，并验证对应 `.product.props` 是否存在。

### 3.4 版本来源
- 库版本由 `Directory.Build.props` 中的 `StackPackageVersion` 统一注入，`SharpMetal.csproj` 直接引用该变量，保证包名与版本号一致。
- 示例项目通过 `$(StackPackageVersion)` 引用同版本包，形成“源码联调时用 ProjectReference，发布时用同名包”的一致性。

## 4. 约定与约束

- **SDK 锁定**：`global.json` 强制使用 `10.0.100`，`allowPrerelease=false`，禁止意外升级 SDK。
- **锁文件强制还原**：`RestorePackagesWithLockFile=true` 配合每项目两份 lock 文件，确保每次还原都严格遵循已提交快照。
- **参考模式互斥**：`StackReferenceMode` 只能取 `Source` 或 `Package`，违反时在 `ValidateStackReferenceMode` Target 报错终止。
- **Source 模式禁止混用包**：当 `StackReferenceMode=Source` 时，任何匹配 `Sharp(Metal|Math|GPU|Shader|Neural|LLM)` 的 `PackageReference` 都会触发错误，强制整个产品图走源码引用。
- **输出隔离**：所有 `bin/obj` 被排除在默认项之外，产物统一写入 `artifacts/`，避免误提交中间文件。
- **平台限定**：库仅针对 `x64` 与 `ARM64` 构建，Sample 应用继承相同 TargetFramework，确保依赖解析在同一框架下进行。
- **本地覆盖**：通过 `stack.local.props`（由 `stack.local.props.example` 提供模板）可覆盖 `StackProductRoot`、`StackLocalProps` 等属性，用于开发者本地环境适配，但不纳入版本控制。

## 5. 现状评估

当前 `SharpMetal` 库本身没有引入任何第三方 NuGet 包（两个 lock 文件中 `net10.0` 依赖为空），依赖关系完全来自 .NET SDK 自身及可选的上游 Stack 产品（如 SharpGPU）。因此依赖管理主要体现为 **构建编排层面的约束与约定**，而非复杂的第三方包治理。若未来引入外部依赖，应遵循现有双锁文件与 Source/Package 模式约定，将新增依赖同时更新两份 lock 文件。