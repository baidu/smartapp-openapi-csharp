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
    public class FindOrderRefundResponsedataItem : SmartBaseResponse
    {
        /// <summary>
        /// 开发者退款批次id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bizRefundBatchId")]
        public string BizRefundBatchID { get; set; }
        /// <summary>
        /// 退款订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orderId")] 
        public long OrderID { get; set; }
        /// <summary>
        /// 退款批次id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refundBatchId")] 
        public long RefundBatchID { get; set; }
        /// <summary>
        /// 退款状态 1 退款中 2 退款成功 3 退款失败
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refundStatus")] 
        public long RefundStatus { get; set; }
        /// <summary>
        /// 退款用户id 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId")] 
        public long UserID { get; set; }
    }
    public class FindOrderRefundResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public IList<FindOrderRefundResponsedataItem> Data { get; set; }
    }

    // 请求类
    public class FindOrderRefundRequest : OpenApiBaseRequest<FindOrderRefundResponse>
    {
        public FindOrderRefundRequest() : base("/rest/2.0/smartapp/pay/paymentservice/findOrderRefund?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&tpOrderId={tpOrderId}&userId={userId}&pmAppKey={pmAppKey}", RestSharp.Method.GET)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 开发者订单 ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tpOrderId")]
        public string TpOrderID { get; set; }
        /// <summary>
        /// 百度收银台用户 ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId")]
        public long UserID { get; set; }
        /// <summary>
        /// 调起百度收银台的支付服务 appKey
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pmAppKey")]
        public string PmAppKey { get; set; }
        
        
    }
}