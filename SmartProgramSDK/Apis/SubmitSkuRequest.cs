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
    public class SubmitSkuResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应参数（如有提交失败的数据会返回失败的 path 和原因）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public string Data { get; set; }
    }
    // JsonRequests
    [DataContract]
    public class SubmitSkuRequestactivityInfoItem {
        /// <summary>
        /// 优惠活动说明，若优惠活动类型已填，则必填
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("activity_desc")]
        public string ActivityDesc { get; set; }
        /// <summary>
        /// 优惠结束时间（时间戳到秒），距离开始时间不长于 6 个月；若优惠活动说明已填，则必填
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("activity_end_time")]
        public long  ActivityEndTime { get; set; }
        /// <summary>
        /// 优惠活动落地页链接，若优惠活动说明已填，则必填
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("activity_path")]
        public string ActivityPath { get; set; }
        /// <summary>
        /// 优惠开始时间（时间戳到秒），最多可早于提交时间 180 个自然日；若优惠活动说明已填，则必填
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("activity_start_time")]
        public long  ActivityStartTime { get; set; }
        /// <summary>
        /// 优惠活动类型，默认值为优惠;不得出现特殊符号；可选文案：领券、红包、补贴、限免、特价、赠品、会员、拼团；如需新增，发邮件至 smartapp-yylzd@baidu.com ，邮件正文请提供 APP key 、小程序名称、页面标题、描述、落地页 path 、新增活动类型
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("activity_type")]
        public string ActivityType { get; set; }
    }
    [DataContract]
    public class SubmitSkuRequestpriceInfo {
        /// <summary>
        /// 优惠活动前的服务原价格
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("org_price")]
        public string OrgPrice { get; set; }
        /// <summary>
        /// 价格统一默认单位是「元」，提交价格字段时不必重复提交单位「元」，比如：98 元/月，价格字段提交 98、单位字段提交「月」；可选单位：小时、天、周、月、年、m² 、m³ 、次、件；支持新增；如需新增，发邮件至 ext_service_category@baidu.com ，邮件正文请提供 APP key 、小程序名称、页面标题、描述、落地页 path 、新增单位
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("org_unit")]
        public string OrgUnit { get; set; }
        /// <summary>
        /// 当前服务的实际成交价格区间：最高价格
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("range_max_price")]
        public string RangeMaxPrice { get; set; }
        /// <summary>
        /// 当前服务的实际成交价格区间：最低价格
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("range_min_price")]
        public string RangeMinPrice { get; set; }
        /// <summary>
        /// 当前服务的实际成交价格，精确价格与价格区间不同时出现
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("real_price")]
        public string RealPrice { get; set; }
    }
    [DataContract]
    public class SubmitSkuRequestBody {
        /// <summary>
        /// 优惠活动，详见：activity_info 字段说明
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("activity_info")]
        public IList<SubmitSkuRequestactivityInfoItem> ActivityInfo { get; set; }
        /// <summary>
        /// 服务按钮内的文案，表达使用服务的动作；字数为两个/四个汉字，推荐文案如下：咨询/立即咨询、问诊/立即问诊、预约/立即预约、预订/立即预订、办理/立即办理、购买/立即购买、购票/立即购票、抢票/立即抢票、订票/立即订票、下单/立即下单、抢购/立即抢购、团购/立即团购、入住/立即入住、查询/立即查询、查看/立即查看、排队/立即排队、进店/立即进店、租车/立即租车、租房/立即租房、充值/立即充值、缴费/立即缴费；如需新增，发邮件至 ext_service_category@baidu.com ，邮件正文请提供 APP key 、小程序名称、页面标题、描述、落地页 path 、新增按钮文案
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("button_name")]
        public string ButtonName { get; set; }
        /// <summary>
        /// 服务简介，服务的文字解释说明，8~34 个字符(汉字占 2 字符)
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("desc")]
        public string Desc { get; set; }
        /// <summary>
        /// 封面图片链接，目前只须传 1 张图片 图片要求： 1.图片内容要求： 图片清晰、干净，不要出现令人不适的内容；不能出现严重影响用户理解的内容截断问题；图片无水印、二维码、logo； 2.相关性&一致性： 图片与标题、服务落地页内容相关、信息一致;单图片最大不能超 2M，只支持 JPG 或 PNG 格式 三种可选图片比例： a.正方形图片，比例 1:1，图片尺寸要求不低于 352 * 352 b.长方形横图，比例 16:9，图片尺寸不低于 1068 * 601 c.长方形竖图，比例 3:4，图片尺寸不低于 372 * 495
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("images")]
        public IList<string> Images { get; set; }
        /// <summary>
        /// 智能小程序落地页链接
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("path")]
        public string Path { get; set; }
        /// <summary>
        /// 服务价格，详见：price_info 字段说明
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("price_info")]
        public SubmitSkuRequestpriceInfo PriceInfo { get; set; }
        /// <summary>
        /// 服务地域，参考附录二，省市之间用英文中划线分割，多个地区之间用英文逗号分割
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("region")]
        public string Region { get; set; }
        /// <summary>
        /// 行业扩展字段，trade_type=1001/1002/1004/5001/5003/7001/7002/7003/13001 时必须设置，详见：各个分类 schema 字段说明
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("schema")]
        public string Schema { get; set; }
        /// <summary>
        /// 服务的属性、亮点；最多三个标签；每个标签字数不超过 5 个汉字；不得出现特殊符号；“官方标”不可提交；多个标签使用英文封号分割
        /// </summary>
        [DataMember]
        [Newtonsoft.Json.JsonProperty("tag")]
        public string Tag { get; set; }
        /// <summary>
        /// 服务标题：描述服务是什么，12~30 个字符(汉字占 2 字符)
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
    public class SubmitSkuRequest : OpenApiBaseRequest<SubmitSkuResponse>
    {
        public SubmitSkuRequest() : base("/rest/2.0/smartapp/server/submit/sku?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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