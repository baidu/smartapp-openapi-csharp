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
    public class DeleteSkuCouponResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public string Data { get; set; }
    }

    // 请求类
    public class DeleteSkuCouponRequest : OpenApiBaseRequest<DeleteSkuCouponResponse>
    {
        public DeleteSkuCouponRequest() : base("/rest/2.0/smartapp/server/delete/skuCoupon?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&app_id={app_id}&path_list={path_list}", RestSharp.Method.POST)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// app_id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        public long AppID { get; set; }
        /// <summary>
        /// 需要删除的资源 path 列表
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path_list")]
        public string PathList { get; set; }
        
        
    }
}