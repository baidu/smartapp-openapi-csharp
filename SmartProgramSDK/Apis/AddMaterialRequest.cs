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
    public class AddMaterialResponsedata : SmartBaseResponse
    {
        /// <summary>
        /// 物料唯一 id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")] 
        public long ID { get; set; }
        /// <summary>
        /// 小程序落地页 path 地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        public string Path { get; set; }
    }
    public class AddMaterialResponse : SmartBaseResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public AddMaterialResponsedata Data { get; set; }
    }

    // 请求类
    public class AddMaterialRequest : OpenApiBaseRequest<AddMaterialResponse>
    {
        public AddMaterialRequest() : base("/rest/2.0/smartapp/articlemount/material/add?sp_sdk_lang=csharp&sp_sdk_ver=1.0.0&access_token={access_token}", RestSharp.Method.POST)
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
        /// app_id
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("app_id")]
        public long AppID { get; set; }
        /// <summary>
        /// 小图片地址，长度不能超过 500 个字符，最小尺寸为 213*213，比例为 1：1，单图最大为 2M
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("imageUrl")]
        public string ImageURL { get; set; }
        /// <summary>
        /// 标题，需要描述完整，能够明确表示小程序或内容的主要信息点，不能全英文，6-30 个字。若选择相应垂类时，此字段只作为兜底展示字段
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// 智能小程序内页链接
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("path")]
        public string Path { get; set; }
        /// <summary>
        /// 一级分类字段
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("category1Code")]
        public string Category1Code { get; set; }
        /// <summary>
        /// 二级分类字段
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("category2Code")]
        public string Category2Code { get; set; }
        /// <summary>
        /// 4-17 个汉字。标题解释说明
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("desc")]
        public string Desc { get; set; }
        /// <summary>
        /// 属性、特点。最多三个标签；每个标签字数不超过 5 个汉字,多个使用因为 / 隔开
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("labelAttr")]
        public string LabelAttr { get; set; }
        /// <summary>
        /// 优惠信息，最多一个标签；每个标签字数不超过 7 个汉字
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("labelDiscount")]
        public string LabelDiscount { get; set; }
        /// <summary>
        /// 按钮文案，最多 4 个字
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("buttonName")]
        public string ButtonName { get; set; }
        /// <summary>
        /// 封面图片链接（1 张，单图片最大 2M）大图模板要求最小尺寸 1068 x 601，比例为 16：9，单图最大为 2M
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("bigImage")]
        public string BigImage { get; set; }
        /// <summary>
        /// 当选择小说/动漫，影视剧，电影票务，演出赛事时必填；（竖图 3：4）最低 213*284
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("verticalImage")]
        public string VerticalImage { get; set; }
        /// <summary>
        /// 扩展信息
        /// </summary>
        [RequestParameter(RestSharp.ParameterType.GetOrPost)]
        [Newtonsoft.Json.JsonProperty("extJson")]
        public string ExtJSON { get; set; }
        
    }
}