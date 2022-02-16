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
    public class GetUnionidResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        public string Unionid { get; set; }
    }
    public class GetUnionidResponse : SmartBaseResponse
    {
        /// <summary>
        /// 详细数据，errno 为 0 的情况下才有意义
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public GetUnionidResponsedata Data { get; set; }
    }

    // 请求类
    public class GetUnionidRequest : OpenApiBaseRequest<GetUnionidResponse>
    {
        public GetUnionidRequest() : base("/rest/2.0/smartapp/getunionid?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// 用户 openid ，需要经过用户登录授权过程获取
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("openid")]
        public string Openid { get; set; }
        
    }
}