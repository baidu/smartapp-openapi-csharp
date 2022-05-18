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
    public class AddOrderSubInfoResponsedataItem : SmartBaseResponse
    {
        /// <summary>
        /// POST 请求参数中 BizAPPID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_app_id")]
        public string BizAppID { get; set; }
        /// <summary>
        /// POST 请求参数中 CateID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cate_id")]
        public string CateID { get; set; }
        /// <summary>
        /// POST 请求参数中 ResourceID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource_id")]
        public string ResourceID { get; set; }
        /// <summary>
        /// 请求受影响行数（即请求是否成功， 0 为失败，非 0 为成功）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rows_affected")]
        public string RowsAffected { get; set; }
    }
    public class AddOrderSubInfoResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public IList<AddOrderSubInfoResponsedataItem> Data { get; set; }
    }
    // Post Json
    [DataContract]
    public class AddOrderSubInfoPostData {
        /// <summary>
        /// 请求数据
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Data")]
        public IList<AddOrderSubInfoRequestDataItem> Data { get; set; }
    }
    // JsonRequests
    [DataContract]
    public class AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemOrderDetail {
        /// <summary>
        /// 默认传 2
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Status")]
        public string Status { get; set; }
        /// <summary>
        /// 售后订单跳转地址，用以小程序跳转 Scheme
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("SwanSchema")]
        public string SwanSchema { get; set; }
    }
    [DataContract]
    public class AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemRefundProductItem {
        /// <summary>
        /// 退款金额（单位：分），即100为1元
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Amount")]
        public long  Amount { get; set; }
        /// <summary>
        /// 商品 ID
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("ID")]
        public string ID { get; set; }
        /// <summary>
        /// 售后商品数量
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Quantity")]
        public long  Quantity { get; set; }
    }
    [DataContract]
    public class AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemRefund {
        /// <summary>
        /// 退款总金额（单位：分），即100为1元。
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Amount")]
        public long Amount { get; set; }
        /// <summary>
        /// 售后商品列表
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Product")]
        public IList<AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemRefundProductItem> Product { get; set; }
    }
    [DataContract]
    public class AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItem {
        /// <summary>
        /// 创建时间（单位：秒）
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("CTime")]
        public long  CTime { get; set; }
        /// <summary>
        /// 修改时间（单位：秒）
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("MTime")]
        public long  MTime { get; set; }
        /// <summary>
        /// 跳转到这个订单的详情结构，详见 Data.Ext.SubsOrder.Item.OrderDetail
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("OrderDetail")]
        public AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemOrderDetail OrderDetail { get; set; }
        /// <summary>
        /// 退款类型，1(仅退款)，2(换货)，3(退款+退货)。
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("OrderType")]
        public long  OrderType { get; set; }
        /// <summary>
        /// 售后订单商品信息，详见 Data.Ext.SubsOrder.Item.Refund
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Refund")]
        public AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItemRefund Refund { get; set; }
        /// <summary>
        /// 售后订单 ID
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("SubOrderID")]
        public string SubOrderID { get; set; }
        /// <summary>
        /// 售后订单状态，同 Data.Ext.SubsOrder.Status 退换货枚举值一致
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("SubStatus")]
        public long  SubStatus { get; set; }
    }
    [DataContract]
    public class AddOrderSubInfoRequestDataItemEXTSubsOrder {
        /// <summary>
        /// 售后订单列表
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Items")]
        public IList<AddOrderSubInfoRequestDataItemEXTSubsOrderItemsItem> Items { get; set; }
        /// <summary>
        /// 所有售后订单的状态汇总最终状态，详见 Data.Ext.SubsOrder.Status 退换货枚举值
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Status")]
        public long  Status { get; set; }
    }
    [DataContract]
    public class AddOrderSubInfoRequestDataItemEXT {
        /// <summary>
        /// 子订单信息（退款、售后订单）
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("SubsOrder")]
        public AddOrderSubInfoRequestDataItemEXTSubsOrder SubsOrder { get; set; }
    }
    [DataContract]
    public class AddOrderSubInfoRequestDataItem {
        /// <summary>
        /// 小程序 AppKey
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("BizAPPID")]
        public string BizAPPID { get; set; }
        /// <summary>
        /// 订单种类：1（实物）、2（虚拟物品）、5（快递服务类）、6（快递服务类无金额订单）、10（上门服务类）、11（上门服务类无金额订单）、15（酒店类）、20（票务类）、25（打车类）、26（打车类无金额订单）
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("CateID")]
        public long  CateID { get; set; }
        /// <summary>
        /// 扩展信息
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("EXT")]
        public AddOrderSubInfoRequestDataItemEXT EXT { get; set; }
        /// <summary>
        /// 开发者接入的唯一订单 ID
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("ResourceID")]
        public string ResourceID { get; set; }
    }

    // 请求类
    public class AddOrderSubInfoRequest : OpenApiBaseRequest<AddOrderSubInfoResponse>
    {
        public AddOrderSubInfoRequest() : base("/rest/2.0/smartapp/ordercenter/app/append/sub/info?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&open_id={open_id}&scene_id={scene_id}&scene_type={scene_type}&pm_app_key={pm_app_key}", RestSharp.Method.POST)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 用户 openId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        public string OpenID { get; set; }
        /// <summary>
        /// 百度收银台分配的平台订单 ID，通知支付状态接口返回的 orderId 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_id")]
        public string SceneID { get; set; }
        /// <summary>
        /// 支付场景类型，开发者请默认传 2 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_type")]
        public long SceneType { get; set; }
        /// <summary>
        /// 调起百度收银台的支付服务 appKey
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pm_app_key")]
        public string PmAppKey { get; set; }
        // Post Json
        [Newtonsoft.Json.JsonProperty("json_body")]
        public string jsonBody { get; set; }

        protected override void OnSetRestRequest(RestRequest restRequest)
        {
            base.OnSetRestRequest(restRequest);
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddJsonBody(jsonBody);
        }
        
    }
}
