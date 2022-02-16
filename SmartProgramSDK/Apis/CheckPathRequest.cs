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
    public class CheckPathResponse : SmartBaseResponse
    {
        /// <summary>
        /// 唯一标识 retrieveId，可用于精确查询检测结果、反馈误判
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public string Data { get; set; }
    }
    // Post Json
    [DataContract]
    public class CheckPathPostData {
        /// <summary>
        /// 检测策略，risk 为 url 里文字的内容违规检测，porn 为图片色情检测，ocr-word 为图片上文字的词表检测，ocr-lead 为图片上文字的诱导模型检测。可以多选，不传默认为 risk，参数值区分大小写
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("type")]
        public IList<string> Type { get; set; }
        /// <summary>
        /// 需要检测的页面 path(一次请求一个 path)，path 字符数不能超过 2460
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("path")]
        public string Path { get; set; }
    }

    // 请求类
    public class CheckPathRequest : OpenApiBaseRequest<CheckPathResponse>
    {
        public CheckPathRequest() : base("/rest/2.0/smartapp/riskDetection/v2/asyncCheckPath?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭据
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        // Post Json
        [Newtonsoft.Json.JsonProperty("json_body")]
        public string jsonBody { get; set; }

        protected override void OnSetRestRequest(RestRequest restRequest)
        {
            base.OnSetRestRequest(restRequest);
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddJsonBody(jsonBody);
        }
        
    }
}