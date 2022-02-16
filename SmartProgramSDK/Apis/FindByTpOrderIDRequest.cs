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
    public class FindByTpOrderIDResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 小程序appid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appId")] 
        public long AppID { get; set; }
        /// <summary>
        /// 小程序appkey
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appKey")] 
        public long AppKey { get; set; }
        /// <summary>
        /// 业务扩展字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bizInfo")]
        public string BizInfo { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")] 
        public long Count { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createTime")] 
        public long CreateTime { get; set; }
        /// <summary>
        /// 跳转百度收银台支付必带参数之一
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dealId")] 
        public long DealID { get; set; }
        /// <summary>
        /// 小程序用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openId")] 
        public long OpenID { get; set; }
        /// <summary>
        /// 百度订单 ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orderId")] 
        public long OrderID { get; set; }
        /// <summary>
        /// 原价
        /// </summary>
        [Newtonsoft.Json.JsonProperty("oriPrice")] 
        public long OriPrice { get; set; }
        /// <summary>
        /// 购物车订单父订单ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentOrderId")] 
        public long ParentOrderID { get; set; }
        /// <summary>
        /// 订单类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentType")] 
        public long ParentType { get; set; }
        /// <summary>
        /// 支付金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payMoney")] 
        public long PayMoney { get; set; }
        /// <summary>
        /// 结算金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlePrice")] 
        public long SettlePrice { get; set; }
        /// <summary>
        /// 订单状态 1未支付 2已支付
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")] 
        public long Status { get; set; }
        /// <summary>
        /// 订单子状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subStatus")] 
        public long SubStatus { get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalMoney")] 
        public long TotalMoney { get; set; }
        /// <summary>
        /// tpid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tpId")] 
        public long TpID { get; set; }
        /// <summary>
        /// 开发者订单ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tpOrderId")]
        public string TpOrderID { get; set; }
        /// <summary>
        /// 支付单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tradeNo")]
        public string TradeNo { get; set; }
        /// <summary>
        /// ordertype
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")] 
        public long Type { get; set; }
        /// <summary>
        /// 用户 id 与支付状态通知中的保持一致
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId")] 
        public long UserID { get; set; }
    }
    public class FindByTpOrderIDResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public FindByTpOrderIDResponsedata Data { get; set; }
    }

    // 请求类
    public class FindByTpOrderIDRequest : OpenApiBaseRequest<FindByTpOrderIDResponse>
    {
        public FindByTpOrderIDRequest() : base("/rest/2.0/smartapp/pay/paymentservice/findByTpOrderId?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&tpOrderId={tpOrderId}&pmAppKey={pmAppKey}", RestSharp.Method.GET)
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
        /// 调起百度收银台的支付服务 appKey
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pmAppKey")]
        public string PmAppKey { get; set; }
        
        
    }
}