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
            var request = new CreateCouponRequest() {};
            // 开发者在此设置请求参数，文档示例中的参数均为示例参数，实际参数请参考对应接口的文档上方的参数说明填写
            // 注意：代码示例中的参数字段基本是驼峰形式，而文档中的参数说明的参数字段基本是下划线形式
            // 如果开发者不想传非必需参数，可以将设置该参数的行注释
            request.AccessToken = "21.670f22033a1662a2c3ad3c581456eb70.8428742.7617053436.818068-80484245"; // 文档中对应字段：access_token，实际使用时请替换成真实参数

            // JsonRequests
            CreateCouponRequestbaseInfodateInfo CreateCouponRequestbaseInfodateInfoVal = new CreateCouponRequestbaseInfodateInfo {
                BeginTimestamp = 1065056456,  // 文档中对应字段：beginTimestamp，实际使用时请替换成真实参数
                EndTimestamp = 1416877562,  // 文档中对应字段：endTimestamp，实际使用时请替换成真实参数
                GetEndTimestamp = 1413056840,  // 文档中对应字段：getEndTimestamp，实际使用时请替换成真实参数
                GetStartTimestamp = 1050888507,  // 文档中对应字段：getStartTimestamp，实际使用时请替换成真实参数
                TimeUnit = 0,  // 文档中对应字段：timeUnit，实际使用时请替换成真实参数
                TimeValue = 0,  // 文档中对应字段：timeValue，实际使用时请替换成真实参数
                Type = 1,  // 文档中对应字段：type，实际使用时请替换成真实参数
            };
            CreateCouponRequestbaseInfo CreateCouponRequestbaseInfoVal = new CreateCouponRequestbaseInfo {
                AppRedirectPath = "/pages/index/index",  // 文档中对应字段：appRedirectPath，实际使用时请替换成真实参数
                CodeType = 1,  // 文档中对应字段：codeType，实际使用时请替换成真实参数
                Color = "B056",  // 文档中对应字段：color，实际使用时请替换成真实参数
                DateInfo = CreateCouponRequestbaseInfodateInfoVal,  // 文档中对应字段：dateInfo，实际使用时请替换成真实参数
                GetLimit = 3,  // 文档中对应字段：getLimit，实际使用时请替换成真实参数
                Quantity = 162,  // 文档中对应字段：quantity，实际使用时请替换成真实参数
                Title = "自动化创建代金券421-24",  // 文档中对应字段：title，实际使用时请替换成真实参数
            };
            
            // PostRequests
            CreateCouponPostData postData = new CreateCouponPostData {
                CouponType = "CASH", // 文档中对应字段：couponType，实际使用时请替换成真实参数
                LeastCost = 15734, // 文档中对应字段：leastCost，实际使用时请替换成真实参数
                ReduceCost = 1484, // 文档中对应字段：reduceCost，实际使用时请替换成真实参数
                Discount = "<no value>", // 文档中对应字段：discount，实际使用时请替换成真实参数
                BaseInfo = CreateCouponRequestbaseInfoVal, // 文档中对应字段：baseInfo，实际使用时请替换成真实参数
                Description = "使用描述", // 文档中对应字段：description，实际使用时请替换成真实参数
                CallbackURL = "/test", // 文档中对应字段：callbackUrl，实际使用时请替换成真实参数
            };

            string postDataStr = JsonConvert.SerializeObject(postData);
            request.jsonBody = postDataStr;

            Task task = TestCreateCouponRequest(request);
            task.Wait();
        }

        public static async Task TestCreateCouponRequest(CreateCouponRequest request)
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