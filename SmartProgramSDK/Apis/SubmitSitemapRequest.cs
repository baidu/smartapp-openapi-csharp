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
    public class SubmitSitemapResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public bool Data { get; set; }
    }

    // 请求类
    public class SubmitSitemapRequest : OpenApiBaseRequest<SubmitSitemapResponse>
    {
        public SubmitSitemapRequest() : base("/rest/2.0/smartapp/access/submitsitemap?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
        {
        }

        // GET
        /// <summary>
        /// 小程序权限校验 Token
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
        /// 描述信息
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("desc")]
        public string Desc { get; set; }
        /// <summary>
        /// 更新频率 3-每天 4-每周
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("frequency")]
        public string Frequency { get; set; }
        /// <summary>
        /// 类型 1-增量/更新； 0-下线/删除
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// sitemap 链接
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("url")]
        public string URL { get; set; }
        
    }
}