using RestSharp;
using SmartProgramSDK.Attributes;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SmartProgramSDK
{
    public class SmartBaseResponse
    {
        [Newtonsoft.Json.JsonProperty("errno")]
        public int ErrNo { get; set; }

        [Newtonsoft.Json.JsonProperty("error")]
        public string Error { get; set; }

        // 目前的问题：各个接口的基本响应字段不一致
        // 后续会统一
        [Newtonsoft.Json.JsonProperty("error_msg")] 
        public string ErrorMsg { get; set; }

        [Newtonsoft.Json.JsonProperty("error_code")] 
        public long ErrorCode { get; set; }

        [Newtonsoft.Json.JsonProperty("errmsg")]
        public string ErrMsg { get; set; }

        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }

        [Newtonsoft.Json.JsonProperty("error_description")]
        public string ErrorDescription { get; set; }

        [Newtonsoft.Json.JsonProperty("request_id")]
        public string RequestId { get; set; }

        [Newtonsoft.Json.JsonProperty("requestId")]
        public string RequestID { get; set; }

        [Newtonsoft.Json.JsonProperty("traceId")]
        public string TraceId { get; set; }

        [Newtonsoft.Json.JsonProperty("timestamp")]
        public string TimeStamp { get; set; }
    }
    public class OpenAPIException: System.ApplicationException
    {
        private long code;
        private string msg;
        public OpenAPIException(long code, string message): base(message)
        {
            this.code = code;
            this.msg = message;
        } 
    }
    public class APIException: System.ApplicationException
    {
        private long code;
        private string msg;
        public APIException(long code, string message): base(message)
        {
            this.code = code;
            this.msg = message;
        } 
    }

    public abstract class OpenApiBaseRequest<T> : SmartBaseRequest<T> where T : SmartBaseResponse
    {
        public OpenApiBaseRequest(string apiPath, Method method = Method.GET, string contentType = "application/x-www-form-urlencoded") : base(apiPath, "https://openapi.baidu.com", method, contentType)
        {

        }
    }


    public abstract class SpApiBaseRequest<T> : SmartBaseRequest<T> where T : SmartBaseResponse
    {
        public SpApiBaseRequest(string apiPath, Method method = Method.GET) : base(apiPath, "https://spapi.baidu.com", method)
        {

        }
    }

    public abstract class SmartBaseRequest<T> where T : SmartBaseResponse
    {

        /// <summary>
        /// 服务地址
        /// </summary>
        private string _apiPath;

        private string _baseUrl;

        private RestClient _restClient;

        private Method _method;

        public object DebugInfo
        {
            get; protected set;
        }

        public SmartBaseRequest(string apiPath, string baseUrl, Method method = Method.GET, string contentType = "application/json")
        {
            _apiPath = apiPath;
            _baseUrl = baseUrl;
            _method = method;
            _restClient = new RestClient(_baseUrl);
        }

        protected virtual Task OnBeginExecuteAsync(CancellationToken token)
        {
            return Task.CompletedTask;
        }

        protected virtual void OnSetRestRequest(RestRequest restRequest)
        {
            var properties = GetType().GetProperties().Where(x => x.Name != nameof(DebugInfo)).ToDictionary(x => x, x => x.GetValue(this));
            foreach (var property in properties)
            {
                var key = ((Newtonsoft.Json.JsonPropertyAttribute)property.Key.GetCustomAttributes(typeof(Newtonsoft.Json.JsonPropertyAttribute), false).FirstOrDefault()).PropertyName;
                object value = string.Empty;
                var parameterType = ParameterType.UrlSegment;
                if (property.Value != null)
                {
                    value = property.Value;
                }
                var requestParameterTypeInfo = property.Key.GetCustomAttributes(typeof(RequestParameterAttribute), false);
                if (requestParameterTypeInfo.Length > 0)
                {
                    var requestParameterAttribute = ((RequestParameterAttribute)requestParameterTypeInfo.FirstOrDefault());
                    parameterType = requestParameterAttribute.ParameterType;
                }
                restRequest.AddParameter(key, value, parameterType);
            }
        }

        public virtual async Task<T> ExecuteAsync(CancellationToken token = default)
        {
            await this.OnBeginExecuteAsync(token);
            RestRequest restRequest = new RestRequest();
            restRequest.Resource = _apiPath;
            OnSetRestRequest(restRequest);
            var restResponse = await _restClient.ExecuteAsync(restRequest, _method, token);
            T result = default;
            if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = restResponse.Content;
                result = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(content);
            }
            DebugInfo = new
            {
                Resource = _apiPath,
                StatusCode = restResponse.StatusCode,
                Response = restResponse.Content
            };
            if (result.ErrorCode != 0) {
                throw new OpenAPIException(result.ErrorCode, result.ErrorMsg);
            }
            if (result.ErrNo != 0) {
                throw new APIException(result.ErrNo, result.ErrMsg);
            }
            return result;
        }
    }


}
