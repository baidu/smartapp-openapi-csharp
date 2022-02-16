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
    public class DeleteTemplateResponse : SmartBaseResponse
    {
    }

    // 请求类
    public class DeleteTemplateRequest : OpenApiBaseRequest<DeleteTemplateResponse>
    {
        public DeleteTemplateRequest() : base("/rest/2.0/smartapp/template/templatedel?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// 模板 id ，发送小程序模板消息时所需
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("template_id")]
        public string TemplateID { get; set; }
        
    }
}