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
    public class CheckImageResponsedataresItem : SmartBaseResponse
    {
        /// <summary>
        /// 检测策略
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
    public class CheckImageResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 是一个对象数组，返回每一种检测策略的结果
        /// </summary>
        [Newtonsoft.Json.JsonProperty("res")]
        public IList<CheckImageResponsedataresItem> Res { get; set; }
        /// <summary>
        /// 调用误判反馈接口时需要该返回值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retrieveId")]
        public string RetrieveID { get; set; }
    }
    public class CheckImageResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public CheckImageResponsedata Data { get; set; }
    }

    // 请求类
    public class CheckImageRequest : OpenApiBaseRequest<CheckImageResponse>
    {
        public CheckImageRequest() : base("/file/2.0/smartapp/riskDetection/v2/syncCheckImage?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭据
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        
        
        // Post Multipart/form-data
        /// <summary>
        /// 图片文件，只支持 PNG、JPG、JPEG 三种格式，且文件大小不能超过 5MB
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("image")]
        public string Image { get; set; }
        /// <summary>
        /// 检测策略，porn 为色情检测，ocr-word 为图片上文字的词表检测，ocr-lead 为图片上文字的诱导检测。可以多选，多个值之间用英文逗号拼接，不传默认为 porn，参数值区分大小写
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }

        protected override void OnSetRestRequest(RestRequest restRequest)
        {
            base.OnSetRestRequest(restRequest);
            restRequest.AddHeader("Content-Type", "multipart/form-data");
            restRequest.AddFile("image", Image);
            restRequest.AddParameter("type", Type);
        }
    }
}