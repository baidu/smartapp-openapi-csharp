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
    public class GetQrCodeResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 二维码 base64 编码字符串
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base64_str")]
        public string Base64Str { get; set; }
        /// <summary>
        /// 小程序二维码短链
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string URL { get; set; }
    }
    public class GetQrCodeResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public GetQrCodeResponsedata Data { get; set; }
    }

    // 请求类
    public class GetQrCodeRequest : OpenApiBaseRequest<GetQrCodeResponse>
    {
        public GetQrCodeRequest() : base("/rest/2.0/smartapp/qrcode/getv2?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// 扫码进入的小程序页面路径，最大长度 4000 字节，可以为空
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("path")]
        public string Path { get; set; }
        /// <summary>
        /// 二维码的宽度（单位：px）。最小 280px，最大 1280px
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("width")]
        public long Width { get; set; }
        /// <summary>
        /// 是否包含二维码内嵌 logo 标识，1001 为不包含，默认包含
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("mf")]
        public long Mf { get; set; }
        /// <summary>
        /// 返回值选项，默认或传 1 时只返回二维码 base64 编码字符串，传 0 只返回 url
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("img_flag")]
        public long ImgFlag { get; set; }
        
    }
}