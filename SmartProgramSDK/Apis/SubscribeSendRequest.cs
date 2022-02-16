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
    public class SubscribeSendResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 消息 id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_key")]
        public string MsgKey { get; set; }
    }
    public class SubscribeSendResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public SubscribeSendResponsedata Data { get; set; }
    }

    // 请求类
    public class SubscribeSendRequest : OpenApiBaseRequest<SubscribeSendResponse>
    {
        public SubscribeSendRequest() : base("/rest/2.0/smartapp/template/message/subscribe/send?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// 所需下发的模板消息的id
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("template_id")]
        public string TemplateID { get; set; }
        /// <summary>
        /// 接收者open_id
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("touser_openId")]
        public string TouserOpenID { get; set; }
        /// <summary>
        /// 订阅 Id ，发送订阅类模板消息时所使用的唯一标识符，开发者自定义的subscribe-id 字段。注意：同一用户在同一个订阅id 下的多次授权不累积下发权限，只能下发一条。若要订阅多条，需要不同订阅 id
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("subscribe_id")]
        public string SubscribeID { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("data")]
        public string Data { get; set; }
        /// <summary>
        /// 点击模板卡片后的跳转页面，仅限本小程序内的页面。支持带参数，示例index?foo=bar，该字段不填默认跳转至首页
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("page")]
        public string Page { get; set; }
        
    }
}