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
            var request = new DeleteCouponBannerRequest() {};
            // 开发者在此设置请求参数，文档示例中的参数均为示例参数，实际参数请参考对应接口的文档上方的参数说明填写
            // 注意：代码示例中的参数字段基本是驼峰形式，而文档中的参数说明的参数字段基本是下划线形式
            // 如果开发者不想传非必需参数，可以将设置该参数的行注释
            request.AccessToken = "27.074f88344a2246a8c4ad3c312535eb34.8348874.4553210666.318088-58601753"; // 文档中对应字段：access_token，实际使用时请替换成真实参数
            // Post Form
            request.CouponID = "8851473542"; // 文档中对应字段：couponId，实际使用时请替换成真实参数
            request.BannerID = 8381606816; // 文档中对应字段：bannerId，实际使用时请替换成真实参数

            

            Task task = TestDeleteCouponBannerRequest(request);
            task.Wait();
        }

        public static async Task TestDeleteCouponBannerRequest(DeleteCouponBannerRequest request)
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