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
    public class SendCouponResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 卡券领取标识
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponTakeId")] 
        public long CouponTakeID { get; set; }
    }
    public class SendCouponResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public SendCouponResponsedata Data { get; set; }
    }

    // 请求类
    public class SendCouponRequest : OpenApiBaseRequest<SendCouponResponse>
    {
        public SendCouponRequest() : base("/rest/2.0/smartapp/v1.0/coupon/send?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// 请求唯一标识 uuid
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("uniqueSendingIdentity")]
        public string UniqueSendingIdentity { get; set; }
        
    }
}