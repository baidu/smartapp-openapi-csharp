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
    public class GetTemplateLibraryListResponsedatalistItem : SmartBaseResponse
    {
        /// <summary>
        /// 模板标题 id（获取模板标题下的关键词库时需要）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        public string ID { get; set; }
        /// <summary>
        /// 模板标题内容
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
    }
    public class GetTemplateLibraryListResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 模板数组，对象中包含模板标题 id 、模板标题内容 title
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        public IList<GetTemplateLibraryListResponsedatalistItem> List { get; set; }
        /// <summary>
        /// 模板库标题总数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")] 
        public long TotalCount { get; set; }
    }
    public class GetTemplateLibraryListResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public GetTemplateLibraryListResponsedata Data { get; set; }
    }

    // 请求类
    public class GetTemplateLibraryListRequest : OpenApiBaseRequest<GetTemplateLibraryListResponse>
    {
        public GetTemplateLibraryListRequest() : base("/rest/2.0/smartapp/template/librarylist?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&offset={offset}&count={count}", RestSharp.Method.GET)
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