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
    public class BatchUploadCouponCodeResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 请求失败数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failNum")]
        public string FailNum { get; set; }
        /// <summary>
        /// 请求成功数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("successNum")]
        public string SuccessNum { get; set; }
    }
    public class BatchUploadCouponCodeResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public BatchUploadCouponCodeResponsedata Data { get; set; }
    }

    // 请求类
    public class BatchUploadCouponCodeRequest : OpenApiBaseRequest<BatchUploadCouponCodeResponse>
    {
        public BatchUploadCouponCodeRequest() : base("/rest/2.0/smartapp/v1.0/coupon/code/batchUpload?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// 卡券 ID
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("couponId")]
        public string CouponID { get; set; }
        /// <summary>
        /// 卡券 Code 码列表
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("couponCodes")]
        public string CouponCodes { get; set; }
        
    }
}