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
    public class GetTemplateLibraryByIDResponsedatakeywordListItem : SmartBaseResponse
    {
        /// <summary>
        /// 关键词内容对应的示例
        /// </summary>
        [Newtonsoft.Json.JsonProperty("example")]
        public string Example { get; set; }
        /// <summary>
        /// 关键词 id ，添加模板时需要
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_id")] 
        public long KeywordID { get; set; }
        /// <summary>
        /// 关键词内容
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }
    }
    public class GetTemplateLibraryByIDResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 模板标题 id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        public string ID { get; set; }
        /// <summary>
        /// 关键字条数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_count")] 
        public long KeywordCount { get; set; }
        /// <summary>
        /// 关键词数组，对象中包含关键词 id 、关键词内容 name 、关键词内容示例 example
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_list")]
        public IList<GetTemplateLibraryByIDResponsedatakeywordListItem> KeywordList { get; set; }
        /// <summary>
        /// 模板标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
    }
    public class GetTemplateLibraryByIDResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public GetTemplateLibraryByIDResponsedata Data { get; set; }
    }

    // 请求类
    public class GetTemplateLibraryByIDRequest : OpenApiBaseRequest<GetTemplateLibraryByIDResponse>
    {
        public GetTemplateLibraryByIDRequest() : base("/rest/2.0/smartapp/template/libraryget?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&id={id}", RestSharp.Method.GET)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 模板标题 id ，可通过接口获取，也可登录小程序后台查看获取
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        public string ID { get; set; }
        
        
    }
}