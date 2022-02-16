/// 本示例基于百度智能小程序服务端开发者 OpenAPI-SDK-C#
/// 使用该示例需要首先下载该 SDK，使用引导见：https://smartprogram.baidu.com/docs/develop/serverapi/introduction_for_openapi_sdk/
/// 使用之前请先确认下 SDK 版本是否为最新版本，如不是，请下载最新版本使用
/// 如使用过程中遇到问题，可以加入如流群：5702992，进行反馈咨询
using System;
using SmartProgramSDK.Apis;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace testSDK
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = new DetectRiskRequest() {};
            // 开发者在此设置请求参数，文档示例中的参数均为示例参数，实际参数请参考对应接口的文档上方的参数说明填写
            // 注意：代码示例中的参数字段基本是驼峰形式，而文档中的参数说明的参数字段基本是下划线形式
            // 如果开发者不想传非必需参数，可以将设置该参数的行注释
            request.AccessToken = "20.384f16582a2364a0c7ad0c772344eb82.0685226.0015725758.047424-26842271"; // 文档中对应字段：access_token，实际使用时请替换成真实参数
            // Post Form
            request.Appkey = "WXF1pGOvo1TTGU7qCMMhEjvFBkF4bO5Z"; // 文档中对应字段：appkey，实际使用时请替换成真实参数
            request.Xtoken = "{\"key\":\"jU+mx3VJ4+k2+JfN7cLPNfQZIVbCAZwhMIlTtnt1yl+YTPK0E+18s30UwTqR8eKQEyKu2Qbd4xknxNNoYl0w8o/0/qemfUNn8pDXmsYnaZz6tM8k8bhRD6TusfOXXqXRo0gWuUdnWttnIhxvYKGwhzL0sUF2fqnxY5S6PUnGE6g=\", \"value\": \"TPHtjm3RTDX2pUpcUjbhRu/t2MA10kF+mFv3DPmNSx8zMsTsT5Yitu+DoQ1CJS8f2tQBHpqzQ5vfW5nV8Zm0HWkkXK6xkF6jSTSEWH4KkLAMdzWwqLKZQTaWG8r+MU+7qOqYF1mc26oB7WSSfPJQ2ZUYpY+8RezUMWK6xyUB/6vEy86HZ1SYZjsfmJOYNcVsh6A5fTsoHDsNBiXYA4KUe1ZxiSzmyLYe2EYjW1XLcL+iUgcToNuH144Ypn+Py4OxOD0lS8BgWVNV4sdGriYuRDAN2rcugPbVscFoEeOcDWIDaHNKs024vDvmQQCc3M8EXsQ2W/NDdze63dgJ2AL6ZLV+4Ahe7ISoxflpRKjvl6Jl51+p4jESon0DLJA54/+n6FAbCifa1mZLvyHJ+gTSR2h0lLSZW1ZntrbeofVP0MZTYsPip2k2Kt5A3G/ABj2K8k1FIx3iM0UQWvPgFFOJ/vbCf6c6FXVDLHDid6V3qGwJ0TTRur1MJH4yVPiS8dltOQkIIAQcK3C+nTgi+EKY5RwwoOYw\"}"; // 文档中对应字段：xtoken，实际使用时请替换成真实参数
            request.Type = "marketing"; // 文档中对应字段：type，实际使用时请替换成真实参数
            request.Clientip = "120.6.6.7"; // 文档中对应字段：clientip，实际使用时请替换成真实参数
            request.Ts = 1255633220; // 文档中对应字段：ts，实际使用时请替换成真实参数
            request.Ev = "1"; // 文档中对应字段：ev，实际使用时请替换成真实参数
            request.Useragent = "Mozilla/7.6 (Macintosh, Intel Mac OS X 67_67_8) AppleWebKit/578.15 (KHTML, like Gecko) Chrome/87.2.0171.23 Safari/015.72"; // 文档中对应字段：useragent，实际使用时请替换成真实参数
            request.Phone = ""; // 文档中对应字段：phone，实际使用时请替换成真实参数

            

            Task task = TestDetectRiskRequest(request);
            task.Wait();
        }

        public static async Task TestDetectRiskRequest(DetectRiskRequest request)
        {
            try {
                var result = await request.ExecuteAsync();
            } catch (OpenAPIException e) {
                // openapi error
                // 可能是 access_token 无效，可以尝试重新生成 access_token
                Console.WriteLine("openapi error: {0}", e);
            } catch (APIException e) {
                // api error
                // 可能是参数错误或没有权限，建议根据错误信息自查或者社区发帖、加群反馈
                Console.WriteLine("api error: {0}", e);
            } catch (Exception e) {
                // 其他错误
                Console.WriteLine("others error: {0}", e);
            }
            // 开发者如果想获取 request.DebugInfo 中 Response 中的某个字段的值
            // 可以利用 result.xx 获取
            // 其中，xx 的值可以根据 IDE 的提示或者查看 SDK 中每个 API 的响应结构体或者响应类中的属性
            // 如：result.Data
            Console.WriteLine("test info: {0}", request.DebugInfo);
        }
    }
}