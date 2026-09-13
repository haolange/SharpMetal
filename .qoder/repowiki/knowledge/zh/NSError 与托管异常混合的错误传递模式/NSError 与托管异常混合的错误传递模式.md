---
kind: error_handling
name: NSError 与托管异常混合的错误传递模式
category: error_handling
scope:
    - '**'
source_files:
    - src/SharpMetal/Foundation/NSError.cs
    - src/SharpMetal/Foundation/NSBundle.cs
    - src/SharpMetal/Metal/MTL4Archive.cs
    - src/SharpMetal/Metal/MTL4Compiler.cs
    - src/SharpMetal/Metal/MTL4CommitFeedback.cs
    - src/SharpMetal/Metal/MTL4CommandQueue.cs
    - samples/SharpMetal.Sample/Program.cs
---

## 1. 使用的系统/方法

SharpMetal 是一个面向 Apple Metal / Foundation 的 .NET 互操作层，错误处理采用 **双轨制**：
- 对 Objective-C 侧 API 调用，使用 Cocoa 风格的 `NSError`（通过 `Foundation.NSError` 结构体）以 `ref NSError` 参数传出；
- 对托管侧参数校验、平台检查、ABI 不一致等场景，直接抛出标准 .NET 异常（`InvalidOperationException`、`ArgumentNullException` 等）。

该仓库没有自定义的异常类型、没有统一的错误码枚举（除 `MTL4CommandQueueError` 外）、没有 `try/catch` 中间件或全局异常处理器。错误传播完全依赖调用方自行检查返回值和 `NSError`。

## 2. 关键文件与位置

| 文件 | 作用 |
|---|---|
| `src/SharpMetal/Foundation/NSError.cs` | 定义 `NSError` 结构体，封装 `domain`、`code`、`userInfo`、`localizedDescription`、`localizedFailureReason` 等属性，并提供 `Error(domain, code, userInfo)` 工厂方法与 `Init(...)` 构造器 |
| `src/SharpMetal/Foundation/NSBundle.cs` | 提供 `PreflightAndReturnError(ref NSError)`、`LoadAndReturnError(ref NSError)` 等 Cocoa 风格返回 bool + out NSError 的方法 |
| `src/SharpMetal/Metal/MTL4Archive.cs` | 大量方法签名形如 `NewComputePipelineState(descriptor, ref NSError error)`，将编译/链接错误回传给调用方 |
| `src/SharpMetal/Metal/MTL4Compiler.cs` | `NewLibrary(descriptor, ref NSError error)` 暴露编译器错误 |
| `src/SharpMetal/Metal/MTL4CommitFeedback.cs` | 暴露 `Error => new(NSError(...))` 属性，从反馈对象中读取错误 |
| `src/SharpMetal/Metal/MTL4CommandQueue.cs` | 定义 `MTL4CommandQueueError` 枚举（None/Timeout/NotPermitted/OutOfMemory/DeviceRemoved/AccessRevoked/Internal），并在 `AddFeedbackHandler` 中使用 `ArgumentNullException.ThrowIfNull(handler)` 做参数校验 |
| `samples/SharpMetal.Sample/Program.cs` | 示例程序用 `InvalidOperationException` 表达 ABI 不匹配、无设备、缓冲区分配失败、读回数据不一致等运行时错误 |

## 3. 架构与约定

- **Objective-C 边界**：所有可能失败的 Objective-C 方法都遵循 Cocoa 命名约定——返回 `bool` 或指针，并通过 `ref NSError` 输出错误详情。调用方必须显式检查返回值并消费 `NSError.Domain`、`NSError.Code`、`NSError.LocalizedDescription` 等字段。
- **托管侧参数校验**：在 ObjectiveC 桥接入口（如 `MTL4CommitOptions.AddFeedbackHandler`）使用 `ArgumentNullException.ThrowIfNull` 进行空引用保护，属于快速失败策略。
- **资源释放**：示例程序在 `finally` 块中手动调用 `ObjectiveCRuntime.Release(ptr)` 释放原生句柄，表明该库未实现托管 `IDisposable` 包装，错误路径下的资源清理由调用方负责。
- **无统一错误模型**：除了 `MTL4CommandQueueError` 这一个局部枚举外，未见跨模块共享的错误类型；不同 API 各自决定是抛异常还是传 `NSError`。

## 4. 约定与约束

- **Cocoa 风格错误优先**：凡是对应 Objective-C 方法的接口，均以 `ref NSError` 作为错误通道，不调用栈抛出托管异常（见 `NSBundle`、`MTL4Archive`、`MTL4Compiler` 等方法签名）。
- **托管侧快速失败**：对非法参数使用 `ArgumentNullException.ThrowIfNull`（已验证于 `MTL4CommandQueue.cs`），对平台/ABI 不一致使用 `InvalidOperationException`（已验证于 `samples/.../Program.cs`）。
- **无 try/catch 包裹底层调用**：核心互操作代码直接调用 `ObjectiveCRuntime.objc_msgSend`，不捕获 P/Invoke 或 Objective-C 异常；错误通过返回值和 `NSError` 向上传播。
- **无全局异常处理**：仓库中未发现 `AppDomain.CurrentDomain.UnhandledException`、`TaskScheduler.UnobservedTaskException` 或类似的全局错误钩子。
- **测试/示例中的断言式错误**：示例程序在检测到不满足前置条件时直接 `throw new InvalidOperationException(...)`，而非返回错误码，说明上层消费者可自行选择抛异常或检查返回值。

总体而言，该仓库的错误处理是“按 API 面分别实现”的模式：Objective-C 侧走 Cocoa `NSError` 约定，托管侧走 .NET 标准异常，两者之间没有统一的转换或包装层。