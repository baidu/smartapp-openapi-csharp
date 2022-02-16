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
    public class DetectRiskResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 风险级别，目前有四个，风险等级依次降低（其中 1 最高，4 最低) 1 - 高危；2 - 嫌疑；3 - 普通；4 - 正常。 建议开发者将风险等级为 1、2 的做拦截处理
        /// </summary>
        [Newtonsoft.Json.JsonProperty("level")]
        public string Level { get; set; }
        /// <summary>
        /// 对应的描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag")]
        public IList<string> Tag { get; set; }
    }
    public class DetectRiskResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public DetectRiskResponsedata Data { get; set; }
    }

    // 请求类
    public class DetectRiskRequest : OpenApiBaseRequest<DetectRiskResponse>
    {
        public DetectRiskRequest() : base("/rest/2.0/smartapp/detectrisk?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// 小程序 appkey，智能小程序 AppKey
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("appkey")]
        public string Appkey { get; set; }
        /// <summary>
        /// 小程序通过swan-getSystemRiskInfo获取的内容,格式：{"key":"xxxx","value":"xxxx"}
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("xtoken")]
        public string Xtoken { get; set; }
        /// <summary>
        /// 运营活动的类型，该值由风控平台分配。目前只有一种 marketing
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 客户端的 IP，非小程序服务本地 IP
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("clientip")]
        public string Clientip { get; set; }
        /// <summary>
        /// 服务器的时间戳，秒级别
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("ts")]
        public long Ts { get; set; }
        /// <summary>
        /// 事件类型，预先分配事件 ID 定义。1、点击活动按钮（或者活动操作），活动相关操作默认选择此事件；2、 进入活动页面；3、注册；4、登录；5、分享；6、点赞；7、评论；8、 提现；9、下单/提单；10、支付；11、业务自定义动作；12、浏览 feed；13、开宝箱；14、领取红包；15、分享 feed；16、做任务；17、签到；18、排行榜；19、邀请；20、新客红包；21、摇一摇；22、语音红包；23、视频红包；24、金融授信；25、答题
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("ev")]
        public string Ev { get; set; }
        /// <summary>
        /// 客户端请求小程序 Server 的 useragent，示例：Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/73.0.3683.75 Safari/537.36
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("useragent")]
        public string Useragent { get; set; }
        /// <summary>
        /// 加密后的电话号码，加密方法：sha1
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("phone")]
        public string Phone { get; set; }
        
    }
}