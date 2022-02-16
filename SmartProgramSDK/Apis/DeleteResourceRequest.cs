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
    public class DeleteResourceResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public bool Data { get; set; }
    }

    // 请求类
    public class DeleteResourceRequest : OpenApiBaseRequest<DeleteResourceResponse>
    {
        public DeleteResourceRequest() : base("/rest/2.0/smartapp/access/deleteresource?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// app_id
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("app_id")]
        public long AppID { get; set; }
        /// <summary>
        /// 智能小程序内页链接
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("path")]
        public string Path { get; set; }
        
    }
}