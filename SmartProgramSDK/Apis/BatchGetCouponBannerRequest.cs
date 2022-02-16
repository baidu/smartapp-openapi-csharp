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
    public class BatchGetCouponBannerResponsedatadataListItem : SmartBaseResponse
    {
        /// <summary>
        /// banner 图跳转的小程序页面路径
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appRedirectPath")]
        public string AppRedirectPath { get; set; }
        /// <summary>
        /// 卡券 banner 记录 id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bannerId")] 
        public long BannerID { get; set; }
        /// <summary>
        /// 卡券 id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponId")]
        public string CouponID { get; set; }
        /// <summary>
        /// 卡券创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createTime")] 
        public long CreateTime { get; set; }
        /// <summary>
        /// 卡券图片推广图链接地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("picUrl")]
        public string PicURL { get; set; }
        /// <summary>
        /// 卡券图片推广图标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// 卡券更新时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("updateTime")] 
        public long UpdateTime { get; set; }
    }
    public class BatchGetCouponBannerResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 响应卡券数据数组
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataList")]
        public IList<BatchGetCouponBannerResponsedatadataListItem> DataList { get; set; }
        /// <summary>
        /// 响应数据页数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pageNo")] 
        public long PageNo { get; set; }
        /// <summary>
        /// 响应数据量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")] 
        public long Total { get; set; }
    }
    public class BatchGetCouponBannerResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public BatchGetCouponBannerResponsedata Data { get; set; }
    }

    // 请求类
    public class BatchGetCouponBannerRequest : OpenApiBaseRequest<BatchGetCouponBannerResponse>
    {
        public BatchGetCouponBannerRequest() : base("/rest/2.0/smartapp/v1.0/coupon/banner/batchGet?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}&couponId={couponId}", RestSharp.Method.GET)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 卡券 ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponId")]
        public string CouponID { get; set; }
        
        
    }
}