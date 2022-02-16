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
    public class CheckTextResponsedataresItem : SmartBaseResponse
    {
        /// <summary>
        /// 检测策略
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
    public class CheckTextResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 是一个对象数组，返回每一种检测策略的结果
        /// </summary>
        [Newtonsoft.Json.JsonProperty("res")]
        public IList<CheckTextResponsedataresItem> Res { get; set; }
        /// <summary>
        /// 调用误判反馈接口时需要该返回值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retrieveId")]
        public string RetrieveID { get; set; }
    }
    public class CheckTextResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public CheckTextResponsedata Data { get; set; }
    }
    // Post Json
    [DataContract]
    public class CheckTextPostData {
        /// <summary>
        /// 检测文本，文本的字节数不能超过 10KB
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("content")]
        public string Content { get; set; }
        /// <summary>
        /// 检测策略，risk 为内容违规检测，lead 为诱导违规检测。可以多选，不传默认为 risk，参数值区分大小写
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("type")]
        public IList<string> Type { get; set; }
    }

    // 请求类
    public class CheckTextRequest : OpenApiBaseRequest<CheckTextResponse>
    {
        public CheckTextRequest() : base("/rest/2.0/smartapp/riskDetection/v2/syncCheckText?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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