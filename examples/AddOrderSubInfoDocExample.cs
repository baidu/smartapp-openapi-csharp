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
            var request = new AddOrderSubInfoRequest() {};
            // 开发者在此设置请求参数，文档示例中的参数均为示例参数，实际参数请参考对应接口的文档上方的参数说明填写
            // 注意：代码示例中的参数字段基本是驼峰形式，而文档中的参数说明的参数字段基本是下划线形式
            // 如果开发者不想传非必需参数，可以将设置该参数的行注释
            request.AccessToken = "28.721f85665a2541a4c6ad0c044221eb05.3287813.8042781138.570833-60088140"; // 文档中对应字段：access_token，实际使用时请替换成真实参数
            request.OpenID = "k56HEREQhWhWWB4WYqYT8ITUGX"; // 文档中对应字段：open_id，实际使用时请替换成真实参数
            request.SceneID = "1815246572722"; // 文档中对应字段：scene_id，实际使用时请替换成真实参数
            request.SceneType = 2; // 文档中对应字段：scene_type，实际使用时请替换成真实参数
            request.PmAppKey = "WXF1pGOvo8TTGU5qCMMhEjvFBkF8bO1Z"; // 文档中对应字段：pm_app_key，实际使用时请替换成真实参数

            // JsonRequests
            AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemOrderDetail AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemOrderDetailVal = new AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemOrderDetail {
                Status = "3",  // 文档中对应字段：Status，实际使用时请替换成真实参数
                SwanSchema = "baiduboxapp://swan/B8GF4AWvCSr01myIs18uqaoYz3pPCSY4/wjz/bdxd/order-detail/order-detail?orderId=214082885240",  // 文档中对应字段：SwanSchema，实际使用时请替换成真实参数
            };
            AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemRefundProductItem AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemRefundProductItemVal = new AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemRefundProductItem {
                Amount = 100,  // 文档中对应字段：Amount，实际使用时请替换成真实参数
                ID = "182454860164",  // 文档中对应字段：ID，实际使用时请替换成真实参数
                Quantity = 1,  // 文档中对应字段：Quantity，实际使用时请替换成真实参数
            };
            AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemRefund AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemRefundVal = new AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemRefund {
                Amount = 1568,  // 文档中对应字段：Amount，实际使用时请替换成真实参数
                
                Product = new List<AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemRefundProductItem> { AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemRefundProductItemVal, },  // 文档中对应字段：Product，实际使用时请替换成真实参数
            };
            AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItem AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemVal = new AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItem {
                CTime = 1571026203,  // 文档中对应字段：CTime，实际使用时请替换成真实参数
                MTime = 1571026203,  // 文档中对应字段：MTime，实际使用时请替换成真实参数
                OrderDetail = AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemOrderDetailVal,  // 文档中对应字段：OrderDetail，实际使用时请替换成真实参数
                OrderType = 1,  // 文档中对应字段：OrderType，实际使用时请替换成真实参数
                Refund = AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemRefundVal,  // 文档中对应字段：Refund，实际使用时请替换成真实参数
                SubOrderID = "onlyOne",  // 文档中对应字段：SubOrderID，实际使用时请替换成真实参数
                SubStatus = 401,  // 文档中对应字段：SubStatus，实际使用时请替换成真实参数
            };
            AddOrderSubInfoRequestDataItemEXTSubsOrder AddOrderSubInfoRequestDataItemEXTSubsOrderVal = new AddOrderSubInfoRequestDataItemEXTSubsOrder {
                
                Items = new List<AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItem> { AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemVal, },  // 文档中对应字段：Items，实际使用时请替换成真实参数
                Status = 0,  // 文档中对应字段：Status，实际使用时请替换成真实参数
            };
            AddOrderSubInfoRequestDataItemEXT AddOrderSubInfoRequestDataItemEXTVal = new AddOrderSubInfoRequestDataItemEXT {
                SubsOrder = AddOrderSubInfoRequestDataItemEXTSubsOrderVal,  // 文档中对应字段：SubsOrder，实际使用时请替换成真实参数
            };
            AddOrderSubInfoRequestDataItem AddOrderSubInfoRequestDataItemVal = new AddOrderSubInfoRequestDataItem {
                BizAPPID = "WXF7pGOvo0TTGU1qCMMhEjvFBkF0bO2Z",  // 文档中对应字段：BizAPPID，实际使用时请替换成真实参数
                CateID = 1,  // 文档中对应字段：CateID，实际使用时请替换成真实参数
                EXT = AddOrderSubInfoRequestDataItemEXTVal,  // 文档中对应字段：EXT，实际使用时请替换成真实参数
                ResourceID = "1503617527214",  // 文档中对应字段：ResourceID，实际使用时请替换成真实参数
            };
            
            // PostRequests
            IList<AddOrderSubInfoRequestDataItem> data = new List<AddOrderSubInfoRequestDataItem> { AddOrderSubInfoRequestDataItemVal, };
            AddOrderSubInfoPostData postData = new AddOrderSubInfoPostData {
                Data = data,  // 文档中对应字段：Data，实际使用时请替换成真实参数
            };

            string postDataStr = JsonConvert.SerializeObject(postData);
            request.jsonBody = postDataStr;

            Task task = TestAddOrderSubInfoRequest(request);
            task.Wait();
        }

        public static async Task TestAddOrderSubInfoRequest(AddOrderSubInfoRequest request)
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
