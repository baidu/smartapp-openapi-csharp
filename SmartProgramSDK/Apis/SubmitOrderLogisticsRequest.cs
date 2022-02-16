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
    public class SubmitOrderLogisticsResponsedataItem : SmartBaseResponse
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
    public class SubmitOrderLogisticsResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public IList<SubmitOrderLogisticsResponsedataItem> Data { get; set; }
    }
    // Post Json
    [DataContract]
    public class SubmitOrderLogisticsPostData {
        /// <summary>
        /// 请求数据
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Data")]
        public IList<SubmitOrderLogisticsRequestDataItem> Data { get; set; }
    }
    // JsonRequests
    [DataContract]
    public class SubmitOrderLogisticsRequestDataItemEXTMainOrderExpress {
        /// <summary>
        /// 快递公司对应的编号，详情请参考快递公司信息码表
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Code")]
        public string Code { get; set; }
        /// <summary>
        /// 快递单号
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("ID")]
        public string ID { get; set; }
        /// <summary>
        /// 快递公司名称
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Name")]
        public string Name { get; set; }
        /// <summary>
        /// 开发者默认传 0
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Status")]
        public long  Status { get; set; }
        /// <summary>
        /// 快递类型，1：商家给用户发货，2：用户给商家退货；开发者根据快递类型传 1 或 2
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Type")]
        public long  Type { get; set; }
    }
    [DataContract]
    public class SubmitOrderLogisticsRequestDataItemEXTMainOrder {
        /// <summary>
        /// 快递信息
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("Express")]
        public SubmitOrderLogisticsRequestDataItemEXTMainOrderExpress Express { get; set; }
    }
    [DataContract]
    public class SubmitOrderLogisticsRequestDataItemEXT {
        /// <summary>
        /// 主订单信息（购买商品订单）
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("MainOrder")]
        public SubmitOrderLogisticsRequestDataItemEXTMainOrder MainOrder { get; set; }
    }
    [DataContract]
    public class SubmitOrderLogisticsRequestDataItem {
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
        public SubmitOrderLogisticsRequestDataItemEXT EXT { get; set; }
        /// <summary>
        /// 开发者接入的唯一订单 ID
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("ResourceID")]
        public string ResourceID { get; set; }
    }

    // 请求类
    public class SubmitOrderLogisticsRequest : OpenApiBaseRequest<SubmitOrderLogisticsResponse>
    {
        public SubmitOrderLogisticsRequest() : base("/rest/2.0/smartapp/ordercenter/app/add/main/logistics?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&open_id={open_id}&scene_id={scene_id}&scene_type={scene_type}&pm_app_key={pm_app_key}", RestSharp.Method.POST)
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