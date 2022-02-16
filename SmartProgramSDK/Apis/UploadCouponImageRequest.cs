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
    public class UploadCouponImageResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 图片地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string URL { get; set; }
    }
    public class UploadCouponImageResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public UploadCouponImageResponsedata Data { get; set; }
    }

    // 请求类
    public class UploadCouponImageRequest : OpenApiBaseRequest<UploadCouponImageResponse>
    {
        public UploadCouponImageRequest() : base("/file/2.0/smartapp/v1.0/coupon/upload/image?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        
        
        // Post Multipart/form-data
        /// <summary>
        /// 卡券图
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("file")]
        public string File { get; set; }

        protected override void OnSetRestRequest(RestRequest restRequest)
        {
            base.OnSetRestRequest(restRequest);
            restRequest.AddHeader("Content-Type", "multipart/form-data");
            restRequest.AddFile("file", File);
        }
    }
}