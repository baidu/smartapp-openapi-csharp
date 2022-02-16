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
            var request = new AddOrderInfoRequest() {};
            // 开发者在此设置请求参数，文档示例中的参数均为示例参数，实际参数请参考对应接口的文档上方的参数说明填写
            // 注意：代码示例中的参数字段基本是驼峰形式，而文档中的参数说明的参数字段基本是下划线形式
            // 如果开发者不想传非必需参数，可以将设置该参数的行注释
            request.AccessToken = "20.804f50487a8770a8c2ad3c280410eb45.2526242.7664075408.626552-16584721"; // 文档中对应字段：access_token，实际使用时请替换成真实参数
            request.OpenID = "k37HEREQhWhWWB5WYqYT8ITUGX"; // 文档中对应字段：open_id，实际使用时请替换成真实参数
            request.SwanID = ""; // 文档中对应字段：swan_id，实际使用时请替换成真实参数
            request.SceneID = "1877107040348"; // 文档中对应字段：scene_id，实际使用时请替换成真实参数
            request.SceneType = 2; // 文档中对应字段：scene_type，实际使用时请替换成真实参数
            request.PmAppKey = "baiduboxapp"; // 文档中对应字段：pm_app_key，实际使用时请替换成真实参数

            // JsonRequests
            AddOrderInfoRequestDataItemEXTMainOrderProductsItemDetailPage AddOrderInfoRequestDataItemEXTMainOrderProductsItemDetailPageVal = new AddOrderInfoRequestDataItemEXTMainOrderProductsItemDetailPage {
                Status = "2",  // 文档中对应字段：Status，实际使用时请替换成真实参数
                SwanSchema = "baiduboxapp://swan/B5GF8AWvCSr73myIs82uqaoYz1pPCSY5/wjz/bdxd/order-detail/order-detail?orderId=883513421046",  // 文档中对应字段：SwanSchema，实际使用时请替换成真实参数
            };
            AddOrderInfoRequestDataItemEXTMainOrderProductsItemSkuAttrItem AddOrderInfoRequestDataItemEXTMainOrderProductsItemSkuAttrItemVal = new AddOrderInfoRequestDataItemEXTMainOrderProductsItemSkuAttrItem {
                Name = "四川大凉山丑苹果脆甜",  // 文档中对应字段：Name，实际使用时请替换成真实参数
                Value = "5斤小果25个左右偏小",  // 文档中对应字段：Value，实际使用时请替换成真实参数
            };
            AddOrderInfoRequestDataItemEXTMainOrderProductsItem AddOrderInfoRequestDataItemEXTMainOrderProductsItemVal = new AddOrderInfoRequestDataItemEXTMainOrderProductsItem {
                Desc = "四川大凉山丑苹果脆甜:5斤小果25个左右偏小;",  // 文档中对应字段：Desc，实际使用时请替换成真实参数
                DetailPage = AddOrderInfoRequestDataItemEXTMainOrderProductsItemDetailPageVal,  // 文档中对应字段：DetailPage，实际使用时请替换成真实参数
                ID = "1685706172538",  // 文档中对应字段：ID，实际使用时请替换成真实参数
                
                ImgList = new List<string> { "xxxxx", },  // 文档中对应字段：ImgList，实际使用时请替换成真实参数
                Name = "四川大凉山丑苹果脆甜红将军盐源丑苹果",  // 文档中对应字段：Name，实际使用时请替换成真实参数
                PayPrice = 2390,  // 文档中对应字段：PayPrice，实际使用时请替换成真实参数
                Price = 2390,  // 文档中对应字段：Price，实际使用时请替换成真实参数
                Quantity = 1,  // 文档中对应字段：Quantity，实际使用时请替换成真实参数
                
                SkuAttr = new List<AddOrderInfoRequestDataItemEXTMainOrderProductsItemSkuAttrItem> { AddOrderInfoRequestDataItemEXTMainOrderProductsItemSkuAttrItemVal, },  // 文档中对应字段：SkuAttr，实际使用时请替换成真实参数
            };
            AddOrderInfoRequestDataItemEXTMainOrderPaymentPreferentialInfoItem AddOrderInfoRequestDataItemEXTMainOrderPaymentPreferentialInfoItemVal = new AddOrderInfoRequestDataItemEXTMainOrderPaymentPreferentialInfoItem {
                Name = "优惠券使用",  // 文档中对应字段：Name，实际使用时请替换成真实参数
                Quantity = 1,  // 文档中对应字段：Quantity，实际使用时请替换成真实参数
                Value = 100,  // 文档中对应字段：Value，实际使用时请替换成真实参数
            };
            AddOrderInfoRequestDataItemEXTMainOrderPaymentPaymentInfoItem AddOrderInfoRequestDataItemEXTMainOrderPaymentPaymentInfoItemVal = new AddOrderInfoRequestDataItemEXTMainOrderPaymentPaymentInfoItem {
                Name = "运费",  // 文档中对应字段：Name，实际使用时请替换成真实参数
                Quantity = 1,  // 文档中对应字段：Quantity，实际使用时请替换成真实参数
                Value = 100,  // 文档中对应字段：Value，实际使用时请替换成真实参数
            };
            AddOrderInfoRequestDataItemEXTMainOrderPayment AddOrderInfoRequestDataItemEXTMainOrderPaymentVal = new AddOrderInfoRequestDataItemEXTMainOrderPayment {
                Amount = 2390,  // 文档中对应字段：Amount，实际使用时请替换成真实参数
                IsPayment = false,  // 文档中对应字段：IsPayment，实际使用时请替换成真实参数
                Method = 1,  // 文档中对应字段：Method，实际使用时请替换成真实参数
                
                PaymentInfo = new List<AddOrderInfoRequestDataItemEXTMainOrderPaymentPaymentInfoItem> { AddOrderInfoRequestDataItemEXTMainOrderPaymentPaymentInfoItemVal, },  // 文档中对应字段：PaymentInfo，实际使用时请替换成真实参数
                
                PreferentialInfo = new List<AddOrderInfoRequestDataItemEXTMainOrderPaymentPreferentialInfoItem> { AddOrderInfoRequestDataItemEXTMainOrderPaymentPreferentialInfoItemVal, },  // 文档中对应字段：PreferentialInfo，实际使用时请替换成真实参数
                Time = 0,  // 文档中对应字段：Time，实际使用时请替换成真实参数
            };
            AddOrderInfoRequestDataItemEXTMainOrderAppraise AddOrderInfoRequestDataItemEXTMainOrderAppraiseVal = new AddOrderInfoRequestDataItemEXTMainOrderAppraise {
                Status = 0,  // 文档中对应字段：Status，实际使用时请替换成真实参数
                SwanSchema = "baiduboxapp://swan/B4GF0AWvCSr27myIs66uqaoYz6pPCSY4/wjz/bdxd/order-detail/order-detail?orderId=464768115632",  // 文档中对应字段：SwanSchema，实际使用时请替换成真实参数
            };
            AddOrderInfoRequestDataItemEXTMainOrderOrderDetail AddOrderInfoRequestDataItemEXTMainOrderOrderDetailVal = new AddOrderInfoRequestDataItemEXTMainOrderOrderDetail {
                Status = 0,  // 文档中对应字段：Status，实际使用时请替换成真实参数
                SwanSchema = "baiduboxapp://swan/B4GF3AWvCSr60myIs40uqaoYz2pPCSY0/wjz/bdxd/order-detail/order-detail?orderId=202655062818",  // 文档中对应字段：SwanSchema，实际使用时请替换成真实参数
            };
            AddOrderInfoRequestDataItemEXTMainOrderPaymentPreferentialInfoItem AddOrderInfoRequestDataItemEXTMainOrderPaymentPreferentialInfoItemVal = new AddOrderInfoRequestDataItemEXTMainOrderPaymentPreferentialInfoItem {
                Name = "优惠券使用",  // 文档中对应字段：Name，实际使用时请替换成真实参数
                Quantity = 1,  // 文档中对应字段：Quantity，实际使用时请替换成真实参数
                Value = 100,  // 文档中对应字段：Value，实际使用时请替换成真实参数
            };
            AddOrderInfoRequestDataItemEXTMainOrderPaymentPaymentInfoItem AddOrderInfoRequestDataItemEXTMainOrderPaymentPaymentInfoItemVal = new AddOrderInfoRequestDataItemEXTMainOrderPaymentPaymentInfoItem {
                Name = "运费",  // 文档中对应字段：Name，实际使用时请替换成真实参数
                Quantity = 1,  // 文档中对应字段：Quantity，实际使用时请替换成真实参数
                Value = 100,  // 文档中对应字段：Value，实际使用时请替换成真实参数
            };
            AddOrderInfoRequestDataItemEXTMainOrderPayment AddOrderInfoRequestDataItemEXTMainOrderPaymentVal = new AddOrderInfoRequestDataItemEXTMainOrderPayment {
                Amount = 2390,  // 文档中对应字段：Amount，实际使用时请替换成真实参数
                IsPayment = false,  // 文档中对应字段：IsPayment，实际使用时请替换成真实参数
                Method = 1,  // 文档中对应字段：Method，实际使用时请替换成真实参数
                
                PaymentInfo = new List<AddOrderInfoRequestDataItemEXTMainOrderPaymentPaymentInfoItem> { AddOrderInfoRequestDataItemEXTMainOrderPaymentPaymentInfoItemVal, },  // 文档中对应字段：PaymentInfo，实际使用时请替换成真实参数
                
                PreferentialInfo = new List<AddOrderInfoRequestDataItemEXTMainOrderPaymentPreferentialInfoItem> { AddOrderInfoRequestDataItemEXTMainOrderPaymentPreferentialInfoItemVal, },  // 文档中对应字段：PreferentialInfo，实际使用时请替换成真实参数
                Time = 0,  // 文档中对应字段：Time，实际使用时请替换成真实参数
            };
            AddOrderInfoRequestDataItemEXTMainOrder AddOrderInfoRequestDataItemEXTMainOrderVal = new AddOrderInfoRequestDataItemEXTMainOrder {
                Appraise = AddOrderInfoRequestDataItemEXTMainOrderAppraiseVal,  // 文档中对应字段：Appraise，实际使用时请替换成真实参数
                OrderDetail = AddOrderInfoRequestDataItemEXTMainOrderOrderDetailVal,  // 文档中对应字段：OrderDetail，实际使用时请替换成真实参数
                Payment = AddOrderInfoRequestDataItemEXTMainOrderPaymentVal,  // 文档中对应字段：Payment，实际使用时请替换成真实参数
                
                Products = new List<AddOrderInfoRequestDataItemEXTMainOrderProductsItem> { AddOrderInfoRequestDataItemEXTMainOrderProductsItemVal, },  // 文档中对应字段：Products，实际使用时请替换成真实参数
            };
            AddOrderInfoRequestDataItemEXT AddOrderInfoRequestDataItemEXTVal = new AddOrderInfoRequestDataItemEXT {
                MainOrder = AddOrderInfoRequestDataItemEXTMainOrderVal,  // 文档中对应字段：MainOrder，实际使用时请替换成真实参数
            };
            AddOrderInfoRequestDataItem AddOrderInfoRequestDataItemVal = new AddOrderInfoRequestDataItem {
                BizAPPID = "WXF0pGOvo5TTGU0qCMMhEjvFBkF4bO0Z",  // 文档中对应字段：BizAPPID，实际使用时请替换成真实参数
                CateID = 1,  // 文档中对应字段：CateID，实际使用时请替换成真实参数
                Ctime = 1233212343,  // 文档中对应字段：Ctime，实际使用时请替换成真实参数
                EXT = AddOrderInfoRequestDataItemEXTVal,  // 文档中对应字段：EXT，实际使用时请替换成真实参数
                Mtime = 1233212343,  // 文档中对应字段：Mtime，实际使用时请替换成真实参数
                ResourceID = "1586655174181",  // 文档中对应字段：ResourceID，实际使用时请替换成真实参数
                Status = 200,  // 文档中对应字段：Status，实际使用时请替换成真实参数
                Title = "test",  // 文档中对应字段：Title，实际使用时请替换成真实参数
            };
            
            // PostRequests
            IList<AddOrderInfoRequestDataItem> data = new List<AddOrderInfoRequestDataItem> { AddOrderInfoRequestDataItemVal, };
            AddOrderInfoPostData postData = new AddOrderInfoPostData {
                Data = data,  // 文档中对应字段：Data，实际使用时请替换成真实参数
            };

            string postDataStr = JsonConvert.SerializeObject(postData);
            request.jsonBody = postDataStr;

            Task task = TestAddOrderInfoRequest(request);
            task.Wait();
        }

        public static async Task TestAddOrderInfoRequest(AddOrderInfoRequest request)
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