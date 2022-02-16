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
    public class ApplyOrderRefundResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 平台退款批次号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refundBatchId")]
        public string RefundBatchID { get; set; }
        /// <summary>
        /// 平台可退退款金额【分为单位】
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refundPayMoney")] 
        public long RefundPayMoney { get; set; }
    }
    public class ApplyOrderRefundResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public ApplyOrderRefundResponsedata Data { get; set; }
    }

    // 请求类
    public class ApplyOrderRefundRequest : OpenApiBaseRequest<ApplyOrderRefundResponse>
    {
        public ApplyOrderRefundRequest() : base("/rest/2.0/smartapp/pay/paymentservice/applyOrderRefund?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        // POST Form
        /// <summary>
        /// 退款金额（单位：分），该字段最大不能超过支付回调中的总金额（totalMoney）
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("applyRefundMoney")]
        public long ApplyRefundMoney { get; set; }
        /// <summary>
        /// 开发者退款批次
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("bizRefundBatchId")]
        public string BizRefundBatchID { get; set; }
        /// <summary>
        /// 是否跳过审核，不需要百度请求开发者退款审核请传 1，默认为0
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("isSkipAudit")]
        public long IsSkipAudit { get; set; }
        /// <summary>
        /// 百度收银台订单 ID
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("orderId")]
        public long OrderID { get; set; }
        /// <summary>
        /// 退款原因
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("refundReason")]
        public string RefundReason { get; set; }
        /// <summary>
        /// 退款类型 1：用户发起退款；2：开发者业务方客服退款；3：开发者服务异常退款。
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("refundType")]
        public long RefundType { get; set; }
        /// <summary>
        /// 开发者订单 ID
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("tpOrderId")]
        public string TpOrderID { get; set; }
        /// <summary>
        /// 百度收银台用户 ID
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("userId")]
        public long UserID { get; set; }
        /// <summary>
        /// 退款通知 url ，不传时默认为在开发者后台配置的 url
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("refundNotifyUrl")]
        public string RefundNotifyURL { get; set; }
        /// <summary>
        /// 调起百度收银台的支付服务 appKey
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("pmAppKey")]
        public string PmAppKey { get; set; }
        
    }
}