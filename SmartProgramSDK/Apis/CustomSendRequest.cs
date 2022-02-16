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
    public class CustomSendResponse : SmartBaseResponse
    {
    }

    // 请求类
    public class CustomSendRequest : OpenApiBaseRequest<CustomSendResponse>
    {
        public CustomSendRequest() : base("/rest/2.0/smartapp/message/custom/send?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// 1:游客登录 2:百度账号登录
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("user_type")]
        public long UserType { get; set; }
        /// <summary>
        /// 用户的 OpenID
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("open_id")]
        public string OpenID { get; set; }
        /// <summary>
        /// 消息类型 text:文本格式 image:图片链接
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("msg_type")]
        public string MsgType { get; set; }
        /// <summary>
        /// 文本消息内容，msg_type ="text" 时必填
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("content")]
        public string Content { get; set; }
        /// <summary>
        /// 图片消息，msg_type ="image" 时必填
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("pic_url")]
        public string PicURL { get; set; }
        
    }
}