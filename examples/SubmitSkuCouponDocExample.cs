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
            var request = new SubmitSkuCouponRequest() {};
            // 开发者在此设置请求参数，文档示例中的参数均为示例参数，实际参数请参考对应接口的文档上方的参数说明填写
            // 注意：代码示例中的参数字段基本是驼峰形式，而文档中的参数说明的参数字段基本是下划线形式
            // 如果开发者不想传非必需参数，可以将设置该参数的行注释
            request.AccessToken = "22.bdc73bb1af1530e84b354f6552b15f07.3757402.8251575610.410524-151360355"; // 文档中对应字段：access_token，实际使用时请替换成真实参数

            // JsonRequests
            SubmitSkuCouponRequestpriceInfo SubmitSkuCouponRequestpriceInfoVal = new SubmitSkuCouponRequestpriceInfo {
                OrgPrice = "1003",  // 文档中对应字段：org_price，实际使用时请替换成真实参数
                RealPrice = "906",  // 文档中对应字段：real_price，实际使用时请替换成真实参数
            };
            SubmitSkuCouponRequestBody SubmitSkuCouponRequestBodyVal = new SubmitSkuCouponRequestBody {
                Desc = "测试数据",  // 文档中对应字段：desc，实际使用时请替换成真实参数
                
                Images = new List<string> { "xxxxx", },  // 文档中对应字段：images，实际使用时请替换成真实参数
                Path = "/test/test/coupon777588",  // 文档中对应字段：path，实际使用时请替换成真实参数
                PriceInfo = SubmitSkuCouponRequestpriceInfoVal,  // 文档中对应字段：price_info，实际使用时请替换成真实参数
                Region = "北京市",  // 文档中对应字段：region，实际使用时请替换成真实参数
                Schema = "{\"coupon_brand_name\":\"三只松鼠\",\"collect_coupon_begin_time\":\"4561-68-86 14:83:31\",\"coupon_use_time\":\"7776-64-45 61:24:04~4445-56-86 55:31:72\",\"coupon_sort\":\"PAY\",\"collect_coupon_end_time\":\"1026-78-85 20:08:03\",\"coupon_brand_logo\":[\"https://mbs7.bdstatic.com/searchbox/mappconsole/image/64818856/e68a7470-33f4-6ba3-aa7f-41c8e101f4ad.jpg\"],\"coupon_stock_value\":38,\"adapt_system_types\":[\"android\"]}",  // 文档中对应字段：schema，实际使用时请替换成真实参数
                Title = "测试数据，请勿审核",  // 文档中对应字段：title，实际使用时请替换成真实参数
                TradeType = 2004,  // 文档中对应字段：trade_type，实际使用时请替换成真实参数
            };
            
            IList<SubmitSkuCouponRequestBody> postData = new List<SubmitSkuCouponRequestBody>{
                SubmitSkuCouponRequestBodyVal,
            };
            string postDataStr = JsonConvert.SerializeObject(postData);
            request.jsonBody = postDataStr;

            Task task = TestSubmitSkuCouponRequest(request);
            task.Wait();
        }

        public static async Task TestSubmitSkuCouponRequest(SubmitSkuCouponRequest request)
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