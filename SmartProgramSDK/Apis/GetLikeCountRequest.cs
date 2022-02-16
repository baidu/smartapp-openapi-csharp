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
    public class GetLikeCountResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 点赞数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("like_count")] 
        public long LikeCount { get; set; }
    }
    public class GetLikeCountResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public GetLikeCountResponsedata Data { get; set; }
    }

    // 请求类
    public class GetLikeCountRequest : OpenApiBaseRequest<GetLikeCountResponse>
    {
        public GetLikeCountRequest() : base("/rest/2.0/smartapp/oss/publisher/ugc/like_count?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&host_name={host_name}", RestSharp.Method.POST)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 宿主名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("host_name")]
        public string HostName { get; set; }
        // POST Form
        /// <summary>
        /// 文章的 ID
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("snid")]
        public string Snid { get; set; }
        /// <summary>
        /// 无 snid_type 的开发者请默认传空串
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("snid_type")]
        public string SnidType { get; set; }
        
    }
}