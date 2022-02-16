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
    public class MisjudgeFeedbackResponse : SmartBaseResponse
    {
    }

    // 请求类
    public class MisjudgeFeedbackRequest : OpenApiBaseRequest<MisjudgeFeedbackResponse>
    {
        public MisjudgeFeedbackRequest() : base("/rest/2.0/smartapp/riskDetection/misjudgeFeedback?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭据
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        // POST Form
        /// <summary>
        /// 前面提交检测接口返回的 retrieveId
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("retrieveId")]
        public string RetrieveID { get; set; }
        
    }
}