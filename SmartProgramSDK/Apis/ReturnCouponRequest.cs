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
    public class ReturnCouponResponse : SmartBaseResponse
    {
        /// <summary>
        /// true 退还成功 false 退还失败
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public bool Data { get; set; }
    }

    // 请求类
    public class ReturnCouponRequest : OpenApiBaseRequest<ReturnCouponResponse>
    {
        public ReturnCouponRequest() : base("/rest/2.0/smartapp/v1.0/coupon/return?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// 卡券 ID
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("couponId")]
        public string CouponID { get; set; }
        /// <summary>
        /// 用户 ID
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("openId")]
        public string OpenID { get; set; }
        /// <summary>
        /// 百度分配的用户领取 id
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("couponTakeId")]
        public long CouponTakeID { get; set; }
        
    }
}