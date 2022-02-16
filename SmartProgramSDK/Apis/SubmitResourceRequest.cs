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
    public class SubmitResourceResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public string Data { get; set; }
    }

    // 请求类
    public class SubmitResourceRequest : OpenApiBaseRequest<SubmitResourceResponse>
    {
        public SubmitResourceRequest() : base("/rest/2.0/smartapp/access/submitresource?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// app_id
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("app_id")]
        public long AppID { get; set; }
        /// <summary>
        /// 内容的介绍，最多 2000 字符
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("body")]
        public string Body { get; set; }
        /// <summary>
        /// 扩展信息（参考文档附录三）
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("ext")]
        public string Ext { get; set; }
        /// <summary>
        /// feed 二级分类（参考文档附录二）
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("feed_sub_type")]
        public string FeedSubType { get; set; }
        /// <summary>
        /// feed 一级分类（参考文档附录二）
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("feed_type")]
        public string FeedType { get; set; }
        /// <summary>
        /// 封面图片链接，要求必须是 JSON 格式，最多 3 张，单图片最大不能超 2M，只支持 JPG 或 PNG 格式（jpeg 不支持），尺寸要求：宽不能低于 372px，且高不能低于 248px。重要提示：图片尺寸越大、清晰度越高、宽高比越接近3:2，越有助于降低不可用风险，促进分发。
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("images")]
        public string Images { get; set; }
        /// <summary>
        /// 资源子类型（参考文档附录一）
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("mapp_sub_type")]
        public string MappSubType { get; set; }
        /// <summary>
        /// 资源类型（参考文档附录一）
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("mapp_type")]
        public string MappType { get; set; }
        /// <summary>
        /// 智能小程序落地页链接
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("path")]
        public string Path { get; set; }
        /// <summary>
        /// 资源标签，英文逗号分割，填写越准确详细可能带来更好的分发效果（最多 10 个，总长度最多 100 字）
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("tags")]
        public string Tags { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
        
    }
}