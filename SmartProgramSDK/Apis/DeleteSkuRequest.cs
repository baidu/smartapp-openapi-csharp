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
    public class DeleteSkuResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public string Data { get; set; }
    }

    // 请求类
    public class DeleteSkuRequest : OpenApiBaseRequest<DeleteSkuResponse>
    {
        public DeleteSkuRequest() : base("/rest/2.0/smartapp/server/delete/sku?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// 需要删除的资源 path 列表
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("path_list")]
        public string PathList { get; set; }
        
    }
}