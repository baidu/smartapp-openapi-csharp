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
    public class SendTemplateMessageResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 消息id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_key")] 
        public long MsgKey { get; set; }
    }
    public class SendTemplateMessageResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public SendTemplateMessageResponsedata Data { get; set; }
    }

    // 请求类
    public class SendTemplateMessageRequest : OpenApiBaseRequest<SendTemplateMessageResponse>
    {
        public SendTemplateMessageRequest() : base("/rest/2.0/smartapp/template/send?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// 小程序模板 ID
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("template_id")]
        public string TemplateID { get; set; }
        /// <summary>
        /// 接收者 open_id 参数不能为空。open_id 为百度用户登录唯一标识，可以通过 SessionKey 获得
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("touser_openId")]
        public string TouserOpenID { get; set; }
        /// <summary>
        /// 发送消息内容
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("data")]
        public string Data { get; set; }
        /// <summary>
        /// 点击模板卡片后的跳转页面，仅限本小程序内的页面。支持带参数，（示例 index?foo=bar），该字段不填默认跳转至首页
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("page")]
        public string Page { get; set; }
        /// <summary>
        /// 场景 id ，例如 formId、orderId、payId。formId 为页面内 form 组件的report-submit属性为 true 时返回 formId ，详见 form 表单
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("scene_id")]
        public string SceneID { get; set; }
        /// <summary>
        /// 场景 type 。1：表单；2：百度收银台订单；3：直连订单
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("scene_type")]
        public long SceneType { get; set; }
        
    }
}