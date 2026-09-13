---
kind: logging_system
name: Metal 原生日志桥接与 Console 诊断输出
category: logging_system
scope:
    - '**'
source_files:
    - src/SharpMetal/Metal/MTLLogState.cs
    - src/SharpMetal/Metal/MTLFunctionLog.cs
    - src/SharpMetal/Metal/MTLCommandBuffer.cs
    - src/SharpMetal/Metal/MTL4CommandBuffer.cs
    - src/SharpMetal/Metal/MTLCommandQueue.cs
    - samples/SharpMetal.Sample/Program.cs
    - src/SharpMetal/ObjectiveCCore/ObjectiveCClass.cs
    - src/SharpMetal/ObjectiveCCore/Selector.cs
---

## 概述

SharpMetal 仓库没有引入 .NET 日志框架（如 `Microsoft.Extensions.Logging`、Serilog、NLog 等），也没有统一的内部结构化日志子系统。仓库中的“日志”能力由两部分组成：

1. **对 Apple Metal 原生日志系统的 P/Invoke 封装**——通过 `MTLLogState`、`MTLLogLevel`、`MTLLogHandler`、`MTLFunctionLog`、`MTLLogContainer` 等类型暴露 Metal 的 `logState` / `addLogHandler:` / `logs` 机制，供上层应用自行订阅并处理 Metal 运行时产生的验证/调试日志。
2. **极少量的 `Console.WriteLine` 诊断输出**——仅出现在示例程序 `samples/SharpMetal.Sample/Program.cs` 以及 Objective-C 运行时包装层 `ObjectiveCClass.cs`、`Selector.cs` 的错误路径中，用于快速失败提示或平台检测反馈。

## 关键文件与类型

- `src/SharpMetal/Metal/MTLLogState.cs`：定义 `MTLLogLevel`（Debug/Info/Notice/Error/Fault/Undef）、`MTLLogHandler` 委托（回调签名 `(IntPtr block, NSString subSystem, NSString category, MTLLogLevel logLevel, NSString message)`）、`MTLLogStateDescriptor`（可配置 `Label`、`Level`、`BufferSize`）和 `MTLLogState`（提供 `addLogHandler`）。这些类型通过 `ObjectiveCRuntime.objc_msgSend` 调用 Objective-C 侧的 `logState`、`setLogState:`、`setLabel:`、`setLevel:`、`setBufferSize:`、`addLogHandler:` selector。
- `src/SharpMetal/Metal/MTLFunctionLog.cs`：定义 `MTLFunctionLogType`（当前仅 `Validation`）、`MTLLogContainer`（实现 `NSFastEnumeration` 以枚举日志条目）、`MTLFunctionLogDebugLocation`（`functionName`、`URL`、`line`、`column`）和 `MTLFunctionLog`（`type`、`encoderLabel`、`function`、`debugLocation`）。
- `src/SharpMetal/Metal/MTLCommandBuffer.cs`：暴露 `LogState` 属性（getter/setter 对应 `logState` / `setLogState:`）和 `Logs` 属性（对应 `logs`），使每个命令缓冲区可独立设置日志级别并获取执行后产生的日志集合。
- `src/SharpMetal/Metal/MTL4CommandBuffer.cs`：同版本 API 的 v4 变体，同样暴露 `LogState`。
- `src/SharpMetal/Metal/MTLCommandQueue.cs`：在队列级别暴露 `LogState`，允许为整个命令队列设置日志级别。
- `samples/SharpMetal.Sample/Program.cs`：使用 `Console.WriteLine` 打印平台检测与测试通过信息；未调用任何 Metal 日志 API。
- `src/SharpMetal/ObjectiveCCore/ObjectiveCClass.cs`、`Selector.cs`：在无法解析类/selector 时通过 `Console.WriteLine` 输出错误消息。

## 架构与约定

- **无内置日志框架**：项目不引用任何 .NET 日志包，也不存在 `ILogger`、`LoggerFactory`、`LogProvider` 等抽象。所有“日志”都是对 Apple 平台的 Metal 日志子系统的直接桥接。
- **Metal 日志是可选且由消费者驱动**：`MTLLogState` 通过 `addLogHandler` 注册回调，回调参数包含 `subSystem`、`category`、`logLevel`、`message` 四个字段，由调用方决定如何消费（例如转发到自身日志系统、写入文件或忽略）。仓库本身不提供默认处理器。
- **日志粒度按对象划分**：`MTLCommandQueue`、`MTLCommandBuffer` 各自暴露 `LogState`，意味着日志级别可以在队列级或命令缓冲级单独配置，符合 Metal 原生的分层设计。
- **函数级日志通过 `Logs` 收集**：命令缓冲区提交后可通过 `Logs` 属性拿到 `MTLLogContainer`，再枚举出 `MTLFunctionLog` 条目，每条包含编码器标签、函数指针和调试位置（文件名、行、列）。
- **Console 输出仅用于诊断**：仓库内仅有的 `Console.WriteLine` 全部位于非核心路径（样本程序、Objective-C 运行时包装层的异常分支），不承载生产日志职责。

## 约束与规则

- 仓库未强制要求使用任何特定日志框架；若需结构化日志，应基于 `MTLLogState.addLogHandler` 将 Metal 日志转接到外部系统。
- 日志级别枚举固定为 `MTLLogLevelDebug` → `MTLLogLevelFault` 五级，外加 `Undefined`，遵循 Apple Metal 原生定义。
- 由于 Metal 仅在 Apple 主机上可用（见 Sample 中的 `OperatingSystem.IsMacOS()/IsIOS()/IsMacCatalyst()` 检查），日志功能也仅限于该运行环境。
- 不存在统一的日志初始化入口、全局日志配置或日志路由中间件；日志行为完全由调用方显式配置 `LogState` 并注册处理器来驱动。