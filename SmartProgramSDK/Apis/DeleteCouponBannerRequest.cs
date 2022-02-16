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
    public class DeleteCouponBannerResponse : SmartBaseResponse
    {
        /// <summary>
        /// true 退还成功 false 退还失败
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public bool Data { get; set; }
    }

    // 请求类
    public class DeleteCouponBannerRequest : OpenApiBaseRequest<DeleteCouponBannerResponse>
    {
        public DeleteCouponBannerRequest() : base("/rest/2.0/smartapp/v1.0/coupon/banner/delete?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// 卡券 banner 记录 id
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("bannerId")]
        public long BannerID { get; set; }
        
    }
}