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
    public class GetAccessTokenResponse : SmartBaseResponse
    {
        /// <summary>
        /// 获取到的凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 凭证有效时间，单位：秒
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")] 
        public long ExpiresIn { get; set; }
    }

    // 请求类
    public class GetAccessTokenRequest : OpenApiBaseRequest<GetAccessTokenResponse>
    {
        public GetAccessTokenRequest() : base("/oauth/2.0/token?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&grant_type={grant_type}&client_id={client_id}&client_secret={client_secret}&scope={scope}", RestSharp.Method.GET)
        {
        }

        // GET
        /// <summary>
        /// 固定为：client_credentials
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grant_type")]
        public string GrantType { get; set; }
        /// <summary>
        /// 智能小程序的 App Key，可在「开发者平台 - 设置 - 开发设置」页中获得。（要先在开发者平台创建小程序）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_id")]
        public string ClientID { get; set; }
        /// <summary>
        /// 智能小程序的 App Secret，请妥善保存，如丢失可在「开发者平台 - 设置 - 开发设置」页面重置后获得，重置后 App Secret 将会被更新。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
        /// <summary>
        /// 固定为：smartapp_snsapi_base
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scope")]
        public string Scope { get; set; }
        
        
    }
}