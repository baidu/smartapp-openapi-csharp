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
    public class AddOrderInfoResponsedataItem : SmartBaseResponse
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
    public class AddOrderInfoResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public IList<AddOrderInfoResponsedataItem> Data { get; set; }
    }
    // Post Json
    [DataContract]
    public class AddOrderInfoPostData {
        /// <summary>
        /// 请求数据
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Data")]
        public IList<AddOrderInfoRequestDataItem> Data { get; set; }
    }
    // JsonRequests
    [DataContract]
    public class AddOrderInfoRequestDataItemEXTMainOrderProductsItemDetailPage {
        /// <summary>
        /// 默认传 2
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Status")]
        public string Status { get; set; }
        /// <summary>
        /// 商品详情页的跳转地址，用以小程序跳转 Scheme 
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("SwanSchema")]
        public string SwanSchema { get; set; }
    }
    [DataContract]
    public class AddOrderInfoRequestDataItemEXTMainOrderProductsItemSkuAttrItem {
        /// <summary>
        /// 规格名称，例如“颜色”或“尺寸”
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Name")]
        public string Name { get; set; }
        /// <summary>
        /// 规格值
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Value")]
        public string Value { get; set; }
    }
    [DataContract]
    public class AddOrderInfoRequestDataItemEXTMainOrderProductsItem {
        /// <summary>
        /// 商品简述
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Desc")]
        public string Desc { get; set; }
        /// <summary>
        /// 商品详情的跳转的跳转结构
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("DetailPage")]
        public AddOrderInfoRequestDataItemEXTMainOrderProductsItemDetailPage DetailPage { get; set; }
        /// <summary>
        /// 商品 ID ，开发者的唯一商品 ID
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("ID")]
        public string ID { get; set; }
        /// <summary>
        /// 商品预览，值为预览图 URL 地址，最多 5 张
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("ImgList")]
        public IList<string> ImgList { get; set; }
        /// <summary>
        /// 商品名字
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Name")]
        public string Name { get; set; }
        /// <summary>
        /// 实付价（单位：分），即100代表1元
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("PayPrice")]
        public long  PayPrice { get; set; }
        /// <summary>
        /// 本商品原价（单位：分），即100代表1元
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Price")]
        public long  Price { get; set; }
        /// <summary>
        /// 本商品的交易数量
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Quantity")]
        public long  Quantity { get; set; }
        /// <summary>
        /// 商品规格，最多 400 个
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("SkuAttr")]
        public IList<AddOrderInfoRequestDataItemEXTMainOrderProductsItemSkuAttrItem> SkuAttr { get; set; }
    }
    [DataContract]
    public class AddOrderInfoRequestDataItemEXTMainOrderPaymentPreferentialInfoItem {
        /// <summary>
        /// 展示名称
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Name")]
        public string Name { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Quantity")]
        public long  Quantity { get; set; }
        /// <summary>
        /// 合计金额（单位：分），即100为1元
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Value")]
        public long  Value { get; set; }
    }
    [DataContract]
    public class AddOrderInfoRequestDataItemEXTMainOrderPaymentPaymentInfoItem {
        /// <summary>
        /// 展示名称
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Name")]
        public string Name { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Quantity")]
        public long  Quantity { get; set; }
        /// <summary>
        /// 合计金额（单位：分），即100为1元
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Value")]
        public long  Value { get; set; }
    }
    [DataContract]
    public class AddOrderInfoRequestDataItemEXTMainOrderPayment {
        /// <summary>
        /// 实付金额（单位：分），即100为1元
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Amount")]
        public long  Amount { get; set; }
        /// <summary>
        /// 是否已付款
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("IsPayment")]
        public bool IsPayment { get; set; }
        /// <summary>
        /// 付款方式，1（在线付），2（货到付款）
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Method")]
        public long  Method { get; set; }
        /// <summary>
        /// 其他付款信息
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("PaymentInfo")]
        public IList<AddOrderInfoRequestDataItemEXTMainOrderPaymentPaymentInfoItem> PaymentInfo { get; set; }
        /// <summary>
        /// 优惠券信息
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("PreferentialInfo")]
        public IList<AddOrderInfoRequestDataItemEXTMainOrderPaymentPreferentialInfoItem> PreferentialInfo { get; set; }
        /// <summary>
        /// 付款时间（单位：秒）
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Time")]
        public long  Time { get; set; }
    }
    [DataContract]
    public class AddOrderInfoRequestDataItemEXTMainOrderAppraise {
        /// <summary>
        /// 0（不可评价状态或已评价状态）、2（待评价状态，允许跳转)
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Status")]
        public long  Status { get; set; }
        /// <summary>
        /// 评价页的跳转地址，用以小程序跳转 Scheme 
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("SwanSchema")]
        public string SwanSchema { get; set; }
    }
    [DataContract]
    public class AddOrderInfoRequestDataItemEXTMainOrderOrderDetail {
        /// <summary>
        /// 默认传 2
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Status")]
        public long  Status { get; set; }
        /// <summary>
        /// 订单详情页的跳转地址，用以小程序跳转 Scheme 
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("SwanSchema")]
        public string SwanSchema { get; set; }
    }
    [DataContract]
    public class AddOrderInfoRequestDataItemEXTMainOrder {
        /// <summary>
        /// 待评价状态订单的评价页结构，仅订单为可评价状态，且还未进行评价时提供该信息
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Appraise")]
        public AddOrderInfoRequestDataItemEXTMainOrderAppraise Appraise { get; set; }
        /// <summary>
        /// 订单详情页的信息
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("OrderDetail")]
        public AddOrderInfoRequestDataItemEXTMainOrderOrderDetail OrderDetail { get; set; }
        /// <summary>
        /// 支付信息
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Payment")]
        public AddOrderInfoRequestDataItemEXTMainOrderPayment Payment { get; set; }
        /// <summary>
        /// 数组，商品信息列表，若商品只有 1 个则数组长度为 1 
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Products")]
        public IList<AddOrderInfoRequestDataItemEXTMainOrderProductsItem> Products { get; set; }
    }
    [DataContract]
    public class AddOrderInfoRequestDataItemEXT {
        /// <summary>
        /// 主订单信息（购买商品订单）
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("MainOrder")]
        public AddOrderInfoRequestDataItemEXTMainOrder MainOrder { get; set; }
    }
    [DataContract]
    public class AddOrderInfoRequestDataItem {
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
        /// 订单创建时间（单位：秒）
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Ctime")]
        public long  Ctime { get; set; }
        /// <summary>
        /// 扩展信息
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("EXT")]
        public AddOrderInfoRequestDataItemEXT EXT { get; set; }
        /// <summary>
        /// 订单最后被修改时间（单位：秒）
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Mtime")]
        public long  Mtime { get; set; }
        /// <summary>
        /// 开发者接入的唯一订单 ID
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("ResourceID")]
        public string ResourceID { get; set; }
        /// <summary>
        /// 订单状态，其值根据CateID不同有不同的定义。CateID = 1 实物订单、CateID = 2 虚拟物品订单、CateID = 5 快递服务类订单、CateID = 6 快递服务类无金额订单、CateID = 10 上门服务类订单、CateID = 11 上门服务类无金额订单、CateID = 15 酒店类订单、CateID = 20 出行票务类订单、CateID = 25 打车类订单、CateID = 26 打车类无金额订单
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Status")]
        public long  Status { get; set; }
        /// <summary>
        /// 订单标题，建议使用订单商品名称
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Title")]
        public string Title { get; set; }
    }

    // 请求类
    public class AddOrderInfoRequest : OpenApiBaseRequest<AddOrderInfoResponse>
    {
        public AddOrderInfoRequest() : base("/rest/2.0/smartapp/ordercenter/app/add/main/info?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&open_id={open_id}&swan_id={swan_id}&scene_id={scene_id}&scene_type={scene_type}&pm_app_key={pm_app_key}", RestSharp.Method.POST)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 百度 App 已登录用户使用 openId 作为用户标识；未登录用户（无 openId 时）使用 swanId 作为用户标识
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        public string OpenID { get; set; }
        /// <summary>
        /// 百度 App 已登录用户使用 openId 作为用户标识；未登录用户（无 openId 时）使用 swanId 作为用户标识
        /// </summary>
        [Newtonsoft.Json.JsonProperty("swan_id")]
        public string SwanID { get; set; }
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