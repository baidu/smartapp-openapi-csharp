using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartProgramSDK.Attributes;
using RestSharp;
using System.Runtime.Serialization;

namespace SmartProgramSDK.Apis
{
    // 响应类
    public class CancelOrderResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public bool Data { get; set; }
    }

    // 请求类
    public class CancelOrderRequest : OpenApiBaseRequest<CancelOrderResponse>
    {
        public CancelOrderRequest() : base("/rest/2.0/smartapp/pay/paymentservice/cancelOrder?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&orderId={orderId}&pmAppKey={pmAppKey}", RestSharp.Method.GET)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 百度订单 ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orderId")]
        public long OrderID { get; set; }
        /// <summary>
        /// 调起百度收银台的支付服务 appKey
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pmAppKey")]
        public string PmAppKey { get; set; }
        
        
    }
}