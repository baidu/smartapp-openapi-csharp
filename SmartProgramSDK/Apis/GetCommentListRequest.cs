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
    public class GetCommentListResponsedatalistItemreplyListItem : SmartBaseResponse
    {
        /// <summary>
        /// 回复内容
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        public string Content { get; set; }
        /// <summary>
        /// 发表时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        public string CreateTime { get; set; }
        /// <summary>
        /// 点赞状态 1:已点赞 0:未点赞
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_uped")]
        public string IsUped { get; set; }
        /// <summary>
        /// 点赞数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("like_count")]
        public string LikeCount { get; set; }
    }
    public class GetCommentListResponsedatalistItem : SmartBaseResponse
    {
        /// <summary>
        /// 评论内容
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        public string Content { get; set; }
        /// <summary>
        /// 发表时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        public string CreateTime { get; set; }
        /// <summary>
        /// 点赞状态 1:已点赞 0:未点赞
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_uped")]
        public string IsUped { get; set; }
        /// <summary>
        /// 点赞数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("like_count")]
        public string LikeCount { get; set; }
        /// <summary>
        /// 回复列表
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reply_list")]
        public IList<GetCommentListResponsedatalistItemreplyListItem> ReplyList { get; set; }
        /// <summary>
        /// 评论ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("srid")]
        public string Srid { get; set; }
        /// <summary>
        /// 主题ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thread_id")]
        public string ThreadID { get; set; }
    }
    public class GetCommentListResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 评论列表
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        public IList<GetCommentListResponsedatalistItem> List { get; set; }
    }
    public class GetCommentListResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public GetCommentListResponsedata Data { get; set; }
    }

    // 请求类
    public class GetCommentListRequest : OpenApiBaseRequest<GetCommentListResponse>
    {
        public GetCommentListRequest() : base("/rest/2.0/smartapp/ma/component/comment/open_list?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&host_name={host_name}", RestSharp.Method.POST)
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
        /// <summary>
        /// 评论的开始偏移量，默认0
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("start")]
        public long Start { get; set; }
        /// <summary>
        /// 获取的评论条数，默认10
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("num")]
        public long Num { get; set; }
        
    }
}