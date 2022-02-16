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
            var request = new SubmitSkuRequest() {};
            // 开发者在此设置请求参数，文档示例中的参数均为示例参数，实际参数请参考对应接口的文档上方的参数说明填写
            // 注意：代码示例中的参数字段基本是驼峰形式，而文档中的参数说明的参数字段基本是下划线形式
            // 如果开发者不想传非必需参数，可以将设置该参数的行注释
            request.AccessToken = "25.bdc38bb8af7011e81b187f3163b62f31.3631670.6446710241.105786-860000803"; // 文档中对应字段：access_token，实际使用时请替换成真实参数

            // JsonRequests
            SubmitSkuRequestpriceInfo SubmitSkuRequestpriceInfoVal = new SubmitSkuRequestpriceInfo {
                OrgPrice = "364",  // 文档中对应字段：org_price，实际使用时请替换成真实参数
                OrgUnit = "天",  // 文档中对应字段：org_unit，实际使用时请替换成真实参数
                RangeMaxPrice = "<no value>",  // 文档中对应字段：range_max_price，实际使用时请替换成真实参数
                RangeMinPrice = "<no value>",  // 文档中对应字段：range_min_price，实际使用时请替换成真实参数
                RealPrice = "211",  // 文档中对应字段：real_price，实际使用时请替换成真实参数
            };
            SubmitSkuRequestactivityInfoItem SubmitSkuRequestactivityInfoItemVal = new SubmitSkuRequestactivityInfoItem {
                ActivityDesc = "满00减1",  // 文档中对应字段：activity_desc，实际使用时请替换成真实参数
                ActivityEndTime = 1608480000,  // 文档中对应字段：activity_end_time，实际使用时请替换成真实参数
                ActivityPath = "/activity/coupon",  // 文档中对应字段：activity_path，实际使用时请替换成真实参数
                ActivityStartTime = 1593985486,  // 文档中对应字段：activity_start_time，实际使用时请替换成真实参数
                ActivityType = "领劵",  // 文档中对应字段：activity_type，实际使用时请替换成真实参数
            };
            SubmitSkuRequestBody SubmitSkuRequestBodyVal = new SubmitSkuRequestBody {
                
                ActivityInfo = new List<SubmitSkuRequestactivityInfoItem> { SubmitSkuRequestactivityInfoItemVal, },  // 文档中对应字段：activity_info，实际使用时请替换成真实参数
                ButtonName = "预订/立即预订",  // 文档中对应字段：button_name，实际使用时请替换成真实参数
                Desc = "测试数据",  // 文档中对应字段：desc，实际使用时请替换成真实参数
                
                Images = new List<string> { "xxxxx", },  // 文档中对应字段：images，实际使用时请替换成真实参数
                Path = "/pages/detail/detail?id=250058",  // 文档中对应字段：path，实际使用时请替换成真实参数
                PriceInfo = SubmitSkuRequestpriceInfoVal,  // 文档中对应字段：price_info，实际使用时请替换成真实参数
                Region = "北京市",  // 文档中对应字段：region，实际使用时请替换成真实参数
                Schema = "{\"hotel_name\":\"北京大酒店\",\"hotel_addr\":\"北京西城区\",\"hotel_score\":\"4.7分\",\"hotel_star\":\"经济型酒店\"}",  // 文档中对应字段：schema，实际使用时请替换成真实参数
                Tag = "饮食健康;中餐",  // 文档中对应字段：tag，实际使用时请替换成真实参数
                Title = "测试数据，请勿审核",  // 文档中对应字段：title，实际使用时请替换成真实参数
                TradeType = 5001,  // 文档中对应字段：trade_type，实际使用时请替换成真实参数
            };
            
            IList<SubmitSkuRequestBody> postData = new List<SubmitSkuRequestBody>{
                SubmitSkuRequestBodyVal,
            };
            string postDataStr = JsonConvert.SerializeObject(postData);
            request.jsonBody = postDataStr;

            Task task = TestSubmitSkuRequest(request);
            task.Wait();
        }

        public static async Task TestSubmitSkuRequest(SubmitSkuRequest request)
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