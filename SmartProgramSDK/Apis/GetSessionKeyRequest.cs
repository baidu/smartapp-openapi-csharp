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
    public class GetSessionKeyResponse : SmartBaseResponse
    {
        /// <summary>
        /// 用户身份标识 不同用户登录同一个小程序获取到的 openid 不同，同一个用户登录不同小程序获取到的 openid 也不同
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        public string Openid { get; set; }
        /// <summary>
        /// 用户的 SessionKey
        /// </summary>
        [Newtonsoft.Json.JsonProperty("session_key")]
        public string SessionKey { get; set; }
    }

    // 请求类
    public class GetSessionKeyRequest : SpApiBaseRequest<GetSessionKeyResponse>
    {
        public GetSessionKeyRequest() : base("/oauth/jscode2sessionkey?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&code={code}&client_id={client_id}&sk={sk}", RestSharp.Method.GET)
        {
        }

        // GET
        /// <summary>
        /// 通过 swan.getLoginCode 获取 Authorization Code 特殊说明：code 中有 @ 符号时，会请求对应的开源宿主，用户身份校验及 SessionKey 生成过程由开源宿主实现
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }
        /// <summary>
        /// 智能小程序的 AppKey
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_id")]
        public string ClientID { get; set; }
        /// <summary>
        /// 智能小程序的 AppSecret
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sk")]
        public string Sk { get; set; }
        
        
    }
}