
# 项目名称
百度智能小程序服务端 OpenAPI SDK for csharp，是基于小程序服务端 OpenAPI 封装的一套让开发者方便使用的 SDK， 它可以帮开发者减少理解和使用 OpenAPI 的成本， 减少开发者直接调用服务端接口不当而引起的错误， 避免在开发中走弯路。


## 环境要求
您的系统需要达到:
- .NETCORE 3.1 及其以上版本


## 快速使用
注意：使用本 SDK 需要首先在[百度智能小程序平台](https://smartprogram.baidu.com/developer/index.html)注册成为百度智能小程序开发者以便获取 AppKey 和 AppSecret。

使用方式可参考 `SmartProgramSDK.Test/UnitTest1.cs` 中的示例或者[百度智能小程序开发文档](https://smartprogram.baidu.com/docs/develop/tutorial/intro/)中的 C# 代码示例。

注意：该示例是测试示例，如果想快速运行该测试以体验本 SDK，可在终端中执行如下命令：
1. `cd SmartProgramSDK/`
2. `dotnet build`
3. `dotnet test -l "console;verbosity=detailed"  SmartProgramSDK.Test/bin/Debug/<.NETVERSION>/SmartProgramSDK.Test.dll /Tests:Test<OpenAPI>Request` （将`<.NETVERSION>` 替换成编译的 .NET 版本，`<OpenAPI>` 替换成 `SmartProgramSDK/Apis` 中的 API）

（ `UnitTest1.cs` 只是方便开发者体验本 SDK，建议开发者实际使用时参考开发者文档中的代码示例）

## 相关
- [百度智能小程序开发文档](https://smartprogram.baidu.com/docs/develop/tutorial/intro/)

## 联系我们
如流群号 "5702992", 如流下载地址：https://infoflow.baidu.com/