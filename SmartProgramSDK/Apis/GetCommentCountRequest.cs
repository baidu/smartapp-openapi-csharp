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
    public class GetCommentCountResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 评论数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment_count")]
        public string CommentCount { get; set; }
    }
    public class GetCommentCountResponse : SmartBaseResponse
    {
        /// <summary>
        /// 互动评论数详细结果
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public GetCommentCountResponsedata Data { get; set; }
    }

    // 请求类
    public class GetCommentCountRequest : OpenApiBaseRequest<GetCommentCountResponse>
    {
        public GetCommentCountRequest() : base("/rest/2.0/smartapp/ma/component/comment/tcount?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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