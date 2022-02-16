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
    public class GetSessionKeyv2Responsedata : SmartBaseResponse
    {
        /// <summary>
        /// 用户身份标识 不同用户登录同一个小程序获取到的 openid 不同，同一个用户登录不同小程序获取到的 openid 也不同
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        public string OpenID { get; set; }
        /// <summary>
        /// 用户的 SessionKey
        /// </summary>
        [Newtonsoft.Json.JsonProperty("session_key")]
        public string SessionKey { get; set; }
    }
    public class GetSessionKeyv2Response : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public GetSessionKeyv2Responsedata Data { get; set; }
    }

    // 请求类
    public class GetSessionKeyv2Request : OpenApiBaseRequest<GetSessionKeyv2Response>
    {
        public GetSessionKeyv2Request() : base("/rest/2.0/smartapp/getsessionkey?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&code={code}", RestSharp.Method.POST)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 通过 swan.getLoginCode 获取 Authorization Code 特殊说明：code 中有 @ 符号时，会请求对应的开源宿主，用户身份校验及 SessionKey 生成过程由开源宿主实现
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }
        
        
    }
}