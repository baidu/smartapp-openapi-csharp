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
    public class GetTemplateListResponsedatalistItem : SmartBaseResponse
    {
        /// <summary>
        /// 模板内容
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        public string Content { get; set; }
        /// <summary>
        /// 模板内容示例
        /// </summary>
        [Newtonsoft.Json.JsonProperty("example")]
        public string Example { get; set; }
        /// <summary>
        /// 模板 id ，发送小程序模板消息时所需
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        public string TemplateID { get; set; }
        /// <summary>
        /// 模板标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
    }
    public class GetTemplateListResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 模板对象数组，对象中包含模板 id 、模板标题 title 、模板内容 content 、模板内容示例 example
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        public IList<GetTemplateListResponsedatalistItem> List { get; set; }
        /// <summary>
        /// 模板库标题总数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")] 
        public long TotalCount { get; set; }
    }
    public class GetTemplateListResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public GetTemplateListResponsedata Data { get; set; }
    }

    // 请求类
    public class GetTemplateListRequest : OpenApiBaseRequest<GetTemplateListResponse>
    {
        public GetTemplateListRequest() : base("/rest/2.0/smartapp/template/templatelist?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&offset={offset}&count={count}", RestSharp.Method.GET)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 用于分页，表示从 offset 开始，默认值为 0
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        public long Offset { get; set; }
        /// <summary>
        /// 用于分页，表示拉取 count 条记录，默认值为 0 ，最大为 20
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        public long Count { get; set; }
        
        
    }
}