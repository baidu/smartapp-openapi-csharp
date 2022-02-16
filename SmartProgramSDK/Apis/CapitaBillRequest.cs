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
    public class CapitaBillResponsedatadataItem : SmartBaseResponse
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createTime")]
        public string CreateTime { get; set; }
        /// <summary>
        /// 账单名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("downloadName")]
        public string DownloadName { get; set; }
        /// <summary>
        /// 导出进度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exportStatus")] 
        public long ExportStatus { get; set; }
        /// <summary>
        /// 下载地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string URL { get; set; }
    }
    public class CapitaBillResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public IList<CapitaBillResponsedatadataItem> Data { get; set; }
        /// <summary>
        /// 总数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalCount")] 
        public long TotalCount { get; set; }
    }
    public class CapitaBillResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public CapitaBillResponsedata Data { get; set; }
    }

    // 请求类
    public class CapitaBillRequest : OpenApiBaseRequest<CapitaBillResponse>
    {
        public CapitaBillRequest() : base("/rest/2.0/smartapp/pay/paymentservice/capitaBill?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&billTime={billTime}&pmAppKey={pmAppKey}", RestSharp.Method.GET)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 对账单日期格式 yyyy-MM-dd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billTime")]
        public string BillTime { get; set; }
        /// <summary>
        /// 调起百度收银台的支付服务 appKey
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pmAppKey")]
        public string PmAppKey { get; set; }
        
        
    }
}