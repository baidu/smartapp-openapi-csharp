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
    public class BatchGetCouponResponsedatadataListItembaseInfodateInfo : SmartBaseResponse
    {
        /// <summary>
        /// 使用开始时间，当 type 为 1 时，beginTimestamp 必传且生效；
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beginTimestamp")] 
        public long BeginTimestamp { get; set; }
        /// <summary>
        /// 使用结束时间，当 type 为 1 时，endTimestamp 必传且生效；
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endTimestamp")] 
        public long EndTimestamp { get; set; }
        /// <summary>
        /// 结束领取时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("getEndTimestamp")] 
        public long GetEndTimestamp { get; set; }
        /// <summary>
        /// 开始领取时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("getStartTimestamp")] 
        public long GetStartTimestamp { get; set; }
        /// <summary>
        /// 时间单位：1-时；2-天；3-月；当 type 为 2 时，timeUnit 必传且生效；
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timeUnit")] 
        public long TimeUnit { get; set; }
        /// <summary>
        /// 时间值；当 type 为 2 时，timeValue 必传且生效；
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timeValue")] 
        public long TimeValue { get; set; }
        /// <summary>
        /// 券使用时间类型： 1：开发者设置使用开始和结束时间，此时，beginTimestamp 和 endTimestamp 必传。 2：领取之后，多久可使用，此时，timeUnit 和 timeValue 必传。相对时间：当规定领取 5 日后失效，10 月 1 日 23:00 领取后，10 月 6 日 23:00 失效。 4：领取之后，多久（自然日）失效，此时，timeUnit 和 timeValue 必传，timeUnit 只能设置为天（timeUnit=2）。自然相对时间：当规定领取 5 个自然日后失效，10 月 1 日 23:00 领取后，10 月 6 日 00:00 失效。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")] 
        public long Type { get; set; }
    }
    public class BatchGetCouponResponsedatadataListItembaseInfo : SmartBaseResponse
    {
        /// <summary>
        /// 卡券背景色
        /// </summary>
        [Newtonsoft.Json.JsonProperty("color")]
        public string Color { get; set; }
        /// <summary>
        /// 使用日期，有效期的信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dateInfo")]
        public BatchGetCouponResponsedatadataListItembaseInfodateInfo DateInfo { get; set; }
        /// <summary>
        /// 每人领取次数限制
        /// </summary>
        [Newtonsoft.Json.JsonProperty("getLimit")] 
        public long GetLimit { get; set; }
        /// <summary>
        /// 优惠券名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
    }
    public class BatchGetCouponResponsedatadataListItem : SmartBaseResponse
    {
        /// <summary>
        /// 基本的卡券数据，所有卡券通用。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("baseInfo")]
        public BatchGetCouponResponsedatadataListItembaseInfo BaseInfo { get; set; }
        /// <summary>
        /// 卡券领取事件推送地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callbackUrl")]
        public string CallbackURL { get; set; }
        /// <summary>
        /// 卡券类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponType")]
        public string CouponType { get; set; }
        /// <summary>
        /// 使用须知：卡券使用方法的介绍
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// 折扣券专用，表示打折力度（格式为百分比），填 80 就是八折。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discount")] 
        public long Discount { get; set; }
    }
    public class BatchGetCouponResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 卡券信息数组
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataList")]
        public IList<BatchGetCouponResponsedatadataListItem> DataList { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pageNo")] 
        public long PageNo { get; set; }
        /// <summary>
        /// 总数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")] 
        public long Total { get; set; }
    }
    public class BatchGetCouponResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public BatchGetCouponResponsedata Data { get; set; }
    }

    // 请求类
    public class BatchGetCouponRequest : OpenApiBaseRequest<BatchGetCouponResponse>
    {
        public BatchGetCouponRequest() : base("/rest/2.0/smartapp/v1.0/coupon/batchGet?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.GET)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        
        
    }
}