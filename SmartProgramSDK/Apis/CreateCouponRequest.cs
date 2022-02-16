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
    public class CreateCouponResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 卡券 ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponId")]
        public string CouponID { get; set; }
    }
    public class CreateCouponResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public CreateCouponResponsedata Data { get; set; }
    }
    // Post Json
    [DataContract]
    public class CreateCouponPostData {
        /// <summary>
        /// 卡券类型，当以上卡券类型无法满足时，可使用通用优惠券类型
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("couponType")]
        public string CouponType { get; set; }
        /// <summary>
        /// 表示可使用的门槛金额（单位：分），不传默认为 0，即无起用门槛
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("leastCost")]
        public long LeastCost { get; set; }
        /// <summary>
        /// 代金券专用，表示减免金额（单位：分）
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("reduceCost")]
        public long ReduceCost { get; set; }
        /// <summary>
        /// 折扣券专用，表示打折力度（格式为百分比），填 80 就是八折。
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("discount")]
        public string Discount { get; set; }
        /// <summary>
        /// 基本的卡券数据，所有卡券通用。
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("baseInfo")]
        public CreateCouponRequestbaseInfo BaseInfo { get; set; }
        /// <summary>
        /// 使用须知：卡券使用方法的介绍
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// 卡券领取事件推送地址
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("callbackUrl")]
        public string CallbackURL { get; set; }
    }
    // JsonRequests
    [DataContract]
    public class CreateCouponRequestbaseInfodateInfo {
        /// <summary>
        /// 使用开始时间，当 type 为 1 时，beginTimestamp 必传且生效；
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("beginTimestamp")]
        public long  BeginTimestamp { get; set; }
        /// <summary>
        /// 使用结束时间，当 type 为 1 时，endTimestamp 必传且生效；
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("endTimestamp")]
        public long  EndTimestamp { get; set; }
        /// <summary>
        /// 结束领取时间
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("getEndTimestamp")]
        public long  GetEndTimestamp { get; set; }
        /// <summary>
        /// 开始领取时间
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("getStartTimestamp")]
        public long  GetStartTimestamp { get; set; }
        /// <summary>
        /// 时间单位：1-时；2-天；3-月；当 type 为 2 时，timeUnit 必传且生效；
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("timeUnit")]
        public long  TimeUnit { get; set; }
        /// <summary>
        /// 时间值；当 type 为 2 时，timeValue 必传且生效；
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("timeValue")]
        public long  TimeValue { get; set; }
        /// <summary>
        /// 券使用时间类型： 1：开发者设置使用开始和结束时间，此时，beginTimestamp 和 endTimestamp 必传。 2：领取之后，多久可使用，此时，timeUnit 和 timeValue 必传。相对时间：当规定领取 5 日后失效，10 月 1 日 23:00 领取后，10 月 6 日 23:00 失效。 4：领取之后，多久（自然日）失效，此时，timeUnit 和 timeValue 必传，timeUnit 只能设置为天（timeUnit=2）。自然相对时间：当规定领取 5 个自然日后失效，10 月 1 日 23:00 领取后，10 月 6 日 00:00 失效。
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("type")]
        public long  Type { get; set; }
    }
    [DataContract]
    public class CreateCouponRequestbaseInfo {
        /// <summary>
        /// 已领取的卡券，从详情頁点击「立即使用」打开小程序页面地址，不传默认打开首页
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("appRedirectPath")]
        public string AppRedirectPath { get; set; }
        /// <summary>
        /// 卡券 Code 码类型，默认为 1，1：开发者自定义 code 码，当 codeType=1 时，需要通过「上传 code 码」接口导入 Code，否则影响领券；2：系统分配 Code 码，当 codeType=2 时，开发者无需上传 Code ，quantity 要求必传非 0 且生效
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("codeType")]
        public long  CodeType { get; set; }
        /// <summary>
        /// 卡券背景色，支持范围： [B010 ～ B160]
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("color")]
        public string Color { get; set; }
        /// <summary>
        /// 有效期信息
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("dateInfo")]
        public CreateCouponRequestbaseInfodateInfo DateInfo { get; set; }
        /// <summary>
        /// 使用日期，有效期的信息。
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("getLimit")]
        public long  GetLimit { get; set; }
        /// <summary>
        /// 卡券库存，默认为 0，当 codeType=2 时，quantity 要求必传且生效
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("quantity")]
        public long  Quantity { get; set; }
        /// <summary>
        /// 优惠券名称，最多 15 字
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
    }

    // 请求类
    public class CreateCouponRequest : OpenApiBaseRequest<CreateCouponResponse>
    {
        public CreateCouponRequest() : base("/rest/2.0/smartapp/v1.0/coupon/create?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
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