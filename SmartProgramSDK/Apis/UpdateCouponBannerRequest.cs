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
    public class UpdateCouponBannerResponse : SmartBaseResponse
    {
        /// <summary>
        /// true 退还成功 false 退还失败
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public bool Data { get; set; }
    }
    // Post Json
    [DataContract]
    public class UpdateCouponBannerPostData {
        /// <summary>
        /// 卡券 ID
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("couponId")]
        public string CouponID { get; set; }
        /// <summary>
        /// 卡券 banner 图片
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("picUrl")]
        public string PicURL { get; set; }
        /// <summary>
        /// 卡券 banner 图标题
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// banner 图跳转的小程序页面路径
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("appRedirectPath")]
        public string AppRedirectPath { get; set; }
        /// <summary>
        /// 卡券 banner 记录 id
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("bannerId")]
        public long BannerID { get; set; }
    }

    // 请求类
    public class UpdateCouponBannerRequest : OpenApiBaseRequest<UpdateCouponBannerResponse>
    {
        public UpdateCouponBannerRequest() : base("/rest/2.0/smartapp/v1.0/coupon/banner/update?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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