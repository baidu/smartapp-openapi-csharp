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
    public class AddTemplateResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 添加至帐号下的模板 id ，发送小程序模板消息时所需
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        public string TemplateID { get; set; }
    }
    public class AddTemplateResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public AddTemplateResponsedata Data { get; set; }
    }

    // 请求类
    public class AddTemplateRequest : OpenApiBaseRequest<AddTemplateResponse>
    {
        public AddTemplateRequest() : base("/rest/2.0/smartapp/template/templateadd?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// 模板标题 id
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("id")]
        public string ID { get; set; }
        /// <summary>
        /// 模板关键词 id 列表，如[1,2,3]
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("keyword_id_list")]
        public string KeywordIDList { get; set; }
        
    }
}