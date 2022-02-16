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
    public class GetPathCheckResultByIDResponsedatadetailItem : SmartBaseResponse
    {
        /// <summary>
        /// 违规图片的链接列表，图片相关的检测策略该字段可能会有值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("harmUrl")]
        public IList<string> HarmURL { get; set; }
        /// <summary>
        /// 检测策略
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
    public class GetPathCheckResultByIDResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 检测状态，0 为初始化，1 为内容抓取，2 为检测中，3 为检测完成，4 为检测失败
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checkStatus")] 
        public long CheckStatus { get; set; }
        /// <summary>
        /// 创建时间戳，单位毫秒
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createTime")] 
        public long CreateTime { get; set; }
        /// <summary>
        /// 是一个对象数组，返回每一种检测策略的结果
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        public IList<GetPathCheckResultByIDResponsedatadetailItem> Detail { get; set; }
    }
    public class GetPathCheckResultByIDResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public GetPathCheckResultByIDResponsedata Data { get; set; }
    }

    // 请求类
    public class GetPathCheckResultByIDRequest : OpenApiBaseRequest<GetPathCheckResultByIDResponse>
    {
        public GetPathCheckResultByIDRequest() : base("/rest/2.0/smartapp/riskDetection/v2/getPathCheckResultByID?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&retrieveId={retrieveId}", RestSharp.Method.GET)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭据
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 异步检测页面接口返回的唯一标识
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retrieveId")]
        public string RetrieveID { get; set; }
        
        
    }
}