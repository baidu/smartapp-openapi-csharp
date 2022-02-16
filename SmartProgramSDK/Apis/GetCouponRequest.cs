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
    public class GetCouponResponsedatabaseInfodateInfo : SmartBaseResponse
    {
        /// <summary>
        /// 使用开始时间，当 type 为 1 时，beginTimestamp 必传且生效；
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beginTimestamp")] 
        public long BeginTimestamp { get; set; }
        /// <summary>
        /// 使用结束时间，当 type 为 1 时，endTimestamp 必传且生效；
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endTimestamp")] 
        public long EndTimestamp { get; set; }
        /// <summary>
        /// 结束领取时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("getEndTimestamp")] 
        public long GetEndTimestamp { get; set; }
        /// <summary>
        /// 开始领取时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("getStartTimestamp")] 
        public long GetStartTimestamp { get; set; }
        /// <summary>
        /// 时间单位：1-时；2-天；3-月；当 type 为 2 时，timeUnit 必传且生效；
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timeUnit")] 
        public long TimeUnit { get; set; }
        /// <summary>
        /// 时间值；当 type 为 2 时，timeValue 必传且生效；
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timeValue")] 
        public long TimeValue { get; set; }
        /// <summary>
        /// 券使用时间类型：1：开发者设置使用开始和结束时间；2：领取之后，多久可使用；当类型为 1 时，beginTimestamp 和 endTimestamp 必传；当类型为 2 时，timeUnit 和 timeValue 必传
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")] 
        public long Type { get; set; }
    }
    public class GetCouponResponsedatabaseInfo : SmartBaseResponse
    {
        /// <summary>
        /// 已领取的卡券，从详情頁点击「立即使用」打开小程序页面地址，不传默认打开首页
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appRedirectPath")]
        public string AppRedirectPath { get; set; }
        /// <summary>
        /// 卡券 Code 码类型，默认为 1，1：开发者自定义 code 码，当 codeType=1 时，需要通过「上传 code 码」接口导入 Code，否则影响领券；2：系统分配 Code 码，当 codeType=2 时，开发者无需上传 Code ，quantity 要求必传非 0 且生效
        /// </summary>
        [Newtonsoft.Json.JsonProperty("codeType")] 
        public long CodeType { get; set; }
        /// <summary>
        /// 卡券背景色，支持范围： [B010 ～ B160]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("color")]
        public string Color { get; set; }
        /// <summary>
        /// 使用日期，有效期的信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dateInfo")]
        public GetCouponResponsedatabaseInfodateInfo DateInfo { get; set; }
        /// <summary>
        /// 每人领取次数限制
        /// </summary>
        [Newtonsoft.Json.JsonProperty("getLimit")] 
        public long GetLimit { get; set; }
        /// <summary>
        /// 卡券库存，默认为 0，当 codeType=2 时，quantity 要求必传且生效
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quantity")] 
        public long Quantity { get; set; }
        /// <summary>
        /// 优惠券名称，最多 15 字
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
    }
    public class GetCouponResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 基本的卡券数据，所有卡券通用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("baseInfo")]
        public GetCouponResponsedatabaseInfo BaseInfo { get; set; }
        /// <summary>
        /// 卡券领取事件推送地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callbackUrl")]
        public string CallbackURL { get; set; }
        /// <summary>
        /// 卡券 ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponId")]
        public string CouponID { get; set; }
        /// <summary>
        /// 卡券类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponType")]
        public string CouponType { get; set; }
        /// <summary>
        /// 使用须知：卡券使用方法的介绍
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// 折扣券专用，表示打折力度（格式为百分比），填 80 就是八折是
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discount")] 
        public long Discount { get; set; }
    }
    public class GetCouponResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public GetCouponResponsedata Data { get; set; }
    }

    // 请求类
    public class GetCouponRequest : OpenApiBaseRequest<GetCouponResponse>
    {
        public GetCouponRequest() : base("/rest/2.0/smartapp/v1.0/coupon/get?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&couponId={couponId}", RestSharp.Method.GET)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 卡券 ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponId")]
        public string CouponID { get; set; }
        
        
    }
}