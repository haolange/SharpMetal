---
kind: configuration_system
name: 基于 MSBuild 全局属性与 Source/Package 双模式的构建配置系统
category: configuration_system
scope:
    - '**'
source_files:
    - Directory.Build.props
    - Directory.Build.targets
    - SharpMetal.product.props
    - stack.local.props.example
    - global.json
    - src/SharpMetal/SharpMetal.csproj
    - samples/SharpMetal.Sample/SharpMetal.Sample.csproj
    - eng/Verify.ps1
---

## 1. 使用的系统与框架

该仓库没有运行时应用配置文件（如 `appsettings.json`、`.env`），其「配置系统」完全由 **MSBuild + .NET SDK** 驱动，通过一组全局 `.props/.targets` 文件集中管理跨产品、跨项目、跨环境的构建行为。核心机制包括：
- 根级 `Directory.Build.props` / `Directory.Build.targets` 注入所有子项目的默认属性。
- 产品级 `SharpMetal.product.props` 声明产品名称。
- 本地覆盖文件 `stack.local.props`（示例见 `stack.local.props.example`）用于开发者切换依赖来源。
- `global.json` 锁定 .NET SDK 版本为 `10.0.100`，并允许 roll-forward 到 latestFeature。
- 验证脚本 `eng/Verify.ps1` 以受控参数驱动 restore/build/pack/test，生成隔离的产物证据目录。

## 2. 关键文件

| 文件 | 作用 |
|---|---|
| `Directory.Build.props` | 导入产品属性、解析 `StackLocalProps`、定义输出路径、锁定 NuGet lock 文件路径、启用确定性构建与 CI 检测 |
| `Directory.Build.targets` | 传递 `Configuration/Platform/RuntimeIdentifier/StackReferenceMode` 给被引用的子项目；在 `CollectPackageReferences` 前校验 `StackReferenceMode` 与源引用映射 |
| `SharpMetal.product.props` | 设置 `StackProductName=SharpMetal` |
| `stack.local.props.example` | 示例：将 `StackReferenceMode` 设为 `Source`，并指向同仓库其他产品的 checkout 根目录 |
| `global.json` | 锁定 SDK 版本与回滚策略 |
| `src/SharpMetal/SharpMetal.csproj` | 目标框架 `net10.0`、平台 `x64;ARM64`、版本号取自 `$(StackPackageVersion)` |
| `samples/SharpMetal.Sample/SharpMetal.Sample.csproj` | 根据 `StackReferenceMode` 选择 `ProjectReference` 或 `PackageReference` |
| `eng/Verify.ps1` | 以 `--locked-mode` 执行 restore/build/pack，并在隔离目录中用生成的 nupkg 重建消费者以验证包完整性 |

## 3. 架构与约定

### 3.1 双层 props 加载顺序
1. 每个项目自动导入根 `Directory.Build.props`。
2. 根 props 先导入 `SharpMetal.product.props` 获取 `StackProductName`。
3. 计算 `StackProductRoot` 后，若未显式指定 `StackLocalProps`，则默认指向 `$(StackProductRoot)/stack.local.props`。
4. 仅当该文件存在时才 `Import`，因此不存在的本地文件不会导致失败。

### 3.2 Source / Package 双依赖模式
- `StackReferenceMode` 默认值为 `Package`，可被 `stack.local.props` 覆盖为 `Source`。
- 示例项目通过条件 ItemGroup 实现二选一：
  - `Source` → `ProjectReference Include="../../src/SharpMetal/SharpMetal.csproj"`
  - `Package` → `PackageReference Include="SharpMetal" Version="$(StackPackageVersion)"`
- `StackPackageVersion` 在根 props 中硬编码为 `0.4.0-preview.1`。

### 3.3 输出与中间文件隔离
- 所有 `bin/obj` 被重定向到 `artifacts/bin/<ProjectName>/<Mode>/<Platform>/<RID>/` 和 `artifacts/obj/...`。
- `RestorePackagesWithLockFile=true`，且 `NuGetLockFilePath` 按 `<Mode>.<RID>` 区分两份 lock 文件（仓库中同时存在 `packages.Package.portable.lock.json` 与 `packages.Source.portable.lock.json`）。
- `DefaultItemExcludes` 排除 `artifacts/**` 与 `bin/**`，避免污染提交。

### 3.4 构建时校验（enforced rules）
`Directory.Build.targets` 中的 `ValidateStackReferenceMode` 目标在 `CollectPackageReferences` 之前执行，强制以下规则：
1. `StackReferenceMode` 必须为 `Source` 或 `Package`，否则报错。
2. 若某 `ProjectReference` 标记了 `StackProduct`，则在 `Package` 模式下直接报错（禁止混合）。
3. 若标记了 `StackProduct` 但未提供对应的 `$(<Product>Root)` 属性，报错提示缺少源检出映射。
4. 若对应目录下不存在 `<Product>.product.props`，报错提示源仓库身份不匹配或缺少检出。
5. 若源项目文件本身不存在，报错且不允许回退到 package。
6. 在 `Source` 模式下，任何对 `SharpMath/Metal/GPU/Shader/Neural/LLM` 的 `PackageReference` 都会被视为冲突并报错。

### 3.5 验证流水线配置
`eng/Verify.ps1` 以幂等方式运行：
- 创建临时 `stack.local.props`（空 Project）并传入 `-p:StackReferenceMode=Source`。
- 使用 `--locked-mode` 恢复与构建，确保锁文件严格生效。
- 若存在 `tests/$product.Tests` 则一并执行测试，结果写入 `results/`。
- 打包后在隔离目录 `isolated consumer` 中用 `NuGet.Config` 指向刚生成的 feed，重新 restore/build 消费者，断言最终依赖不包含 project 类型。
- 最终产出 `result.json` 包含 `packageSha256` 等签名信息。

## 4. 约定与约束

- **SDK 锁定**：`global.json` 要求使用 `10.0.100`，禁止预发行版（`allowPrerelease=false`）。
- **确定性构建**：`Deterministic=true`，CI 下 `ContinuousIntegrationBuild=true`。
- **平台限制**：库限定 `Platforms=x64;ARM64`；验证脚本仅在 Windows 上运行（`if (-not $IsWindows) { throw ... }`）。
- **NuGet 锁文件分离**：每种 `StackReferenceMode` 与 `RuntimeIdentifier` 组合对应独立 lock 文件，路径由 `packages.$(StackReferenceMode).$(_StackOutputRid).lock.json` 决定。
- **源/包互斥**：同一构建图不能同时出现 source 引用与同名 package 引用，由 targets 中的正则匹配强制。
- **本地覆盖文件命名**：开发者应复制 `stack.local.props.example` 为 `stack.local.props` 来覆盖默认值，该文件不应提交（已被 `.gitignore` 忽略）。
- **产物位置固定**：所有中间产物集中在 `artifacts/`，根目录保持干净，便于 CI 缓存与发布。

该系统本质上是 **纯构建期配置**，不涉及运行时配置加载；它通过 MSBuild 全局属性、条件导入与验证目标，将多产品栈的依赖来源、输出布局、SDK 版本与验证流程统一编排。