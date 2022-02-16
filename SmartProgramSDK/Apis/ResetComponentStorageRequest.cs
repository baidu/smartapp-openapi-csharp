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
    public class ResetComponentStorageResponse : SmartBaseResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_code")] 
        public long ErrorCode { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_msg")]
        public string ErrorMsg { get; set; }
        /// <summary>
        /// 请求 ID，标识一次请求
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logid")]
        public string Logid { get; set; }
    }

    // 请求类
    public class ResetComponentStorageRequest : OpenApiBaseRequest<ResetComponentStorageResponse>
    {
        public ResetComponentStorageRequest() : base("/rest/2.0/smartapp/storage/component/reset?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        
        
    }
}