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
    public class SubmitSkuCouponResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应参数（如有提交失败的数据会返回失败的 path 和原因）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public string Data { get; set; }
    }
    // JsonRequests
    [DataContract]
    public class SubmitSkuCouponRequestpriceInfo {
        /// <summary>
        /// 付费优惠券：优惠活动前的服务原价格，注意，是以分为单位
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("org_price")]
        public string OrgPrice { get; set; }
        /// <summary>
        /// 付费优惠券：当前服务的实际成交价格，注意，是以分为单位
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("real_price")]
        public string RealPrice { get; set; }
    }
    [DataContract]
    public class SubmitSkuCouponRequestBody {
        /// <summary>
        /// 优惠券简介，优惠券的文字解释说明，8~34 个字符(汉字占 2 字符)
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("desc")]
        public string Desc { get; set; }
        /// <summary>
        /// 优惠券图片比例为 1：1，像素不得低于 576 * 576,支持 png、jpg 图片内容要求：图片清晰、干净，不要出现令人不适的内容；不能出现严重影响用户理解的内容截断问题；图片无水印、二维码相关性&一致性：图片与标题、优惠落地页内容相关、信息一致
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("images")]
        public IList<string> Images { get; set; }
        /// <summary>
        /// 智能小程序落地页链接，免费优惠券 path 填写格式为 /pages/detail/highVersionIndex/?biz_id=2&biz_app_id= 小程序 appKey&coupon_template_id= 卡券 id&is_activity=0
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("path")]
        public string Path { get; set; }
        /// <summary>
        /// 服务价格，详见：price_info 字段说明
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("price_info")]
        public SubmitSkuCouponRequestpriceInfo PriceInfo { get; set; }
        /// <summary>
        /// 服务地域，参考附录二，省市之间用英文中划线分割，多个地区之间用英文逗号分割
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("region")]
        public string Region { get; set; }
        /// <summary>
        /// 优惠券的具体信息，详见：coupon_info
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("schema")]
        public string Schema { get; set; }
        /// <summary>
        /// 优惠券标题：活动优惠信息说明，12-30 个字符(汉字占 2 字符)；不允许有特殊符号；优惠活动信息必须真实；需要清晰地说明商品内容，说明券的品牌（如肯德基、爱奇艺）、优惠主体（如 30 元代金券、汉堡薯条炸鸡兑换券）
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// 服务类目编码，参考附录一
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("trade_type")]
        public long  TradeType { get; set; }
    }

    // 请求类
    public class SubmitSkuCouponRequest : OpenApiBaseRequest<SubmitSkuCouponResponse>
    {
        public SubmitSkuCouponRequest() : base("/rest/2.0/smartapp/server/submit/skuCoupon?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
        {
        }

        // GET
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        // Post Json
        [Newtonsoft.Json.JsonProperty("json_body")]
        public string jsonBody { get; set; }

        protected override void OnSetRestRequest(RestRequest restRequest)
        {
            base.OnSetRestRequest(restRequest);
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddJsonBody(jsonBody);
        }
        
    }
}