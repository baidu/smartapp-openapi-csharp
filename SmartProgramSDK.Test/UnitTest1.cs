using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using SmartProgramSDK.Apis;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SmartProgramSDK.Test
{
    [TestClass]
    public class UnitTest1
    {
        public static string appKey = "xxxxx";
        public static int appid = 0;
        public static string appSecret = "xxxxx";
        public static string accessToken = "xxxxx";
        public static string openid = "xxxxx";
        public static string code = "xxxxx";
        public static string hostName = "baiduboxapp";

        [TestMethod]
        public async Task TestGetUnionidRequest()
        {
            var request = new GetUnionidRequest() { AccessToken = accessToken, Openid = openid };
            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestGetSessionKeyRequest()
        {
            var request = new GetSessionKeyRequest() { ClientID = appKey, Sk = appSecret };
            request.Code = "xxxxx";
            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestDetectRiskRequest()
        {
            var request = new DetectRiskRequest() { AccessToken = accessToken };
            request.Appkey = appKey;
            request.Xtoken = "{\"key\":\"xxx\", \"value\": \"xxxx\"}";
            request.Type = "marketing";
            request.Clientip = "xx.xx.xx.xx";
            request.Ts = 0;
            request.Ev = "1";
            request.Useragent = "xxxxx";

            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestAccessTokenRequest()
        {
            var request = new GetAccessTokenRequest() { };
            request.ClientID = "xxxxx";
            request.ClientSecret = "xxxxx";
            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
            result.AccessToken.ShouldNotBeNullOrEmpty();
        }

        [TestMethod]
        public async Task TestGetCommentCountRequest()
        {
            var request = new GetCommentCountRequest() { AccessToken = accessToken };
            
            request.Snid = "";
            request.SnidType = "";

            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestGetLikeCountRequest()
        {
            var request = new GetLikeCountRequest() { AccessToken = accessToken };
            
            request.HostName = hostName;
            request.Snid = "";
            request.SnidType = "";
            
            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestGetCommentListRequest()
        {
        var request = new GetCommentListRequest() { AccessToken = accessToken };
            
            request.HostName = hostName;
            request.Snid = "";
            request.SnidType = "";
            request.Start = 0;
            request.Num = 10;

            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestSubmitResourceRequest()
        {
            var request = new SubmitResourceRequest() { AccessToken = accessToken };
            request.AppID = appid;
            request.Body = "??????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????...";
            request.Ext = "{\"publish_time\": \"2021???11???1???\"}";
            request.FeedType = "";
            request.FeedSubType = "";
            request.MappType = "1000";
            request.MappSubType = "1001";
            request.Images = "[\"https:xxx.jpg\"]";
            request.Path = "/pages/detail/xx?id=xx";
            request.Tags = "??????";
            request.Title = "xxx";

            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestDeleteResourceRequest()
        {
            var request = new DeleteResourceRequest() { AccessToken = accessToken };
            
            request.AppID = appid;
            request.Path = "/pages/detail/xxx?id=xxx";

            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestSubmitSitemapRequest()
        {
            var request = new SubmitSitemapRequest() { AccessToken = accessToken };
            
            request.AppID = appid;
            request.Desc = "?????????????????????";
            request.Type = "1";
            request.Frequency = "3";
            request.URL = "https://xxx.json";

            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestDeleteSitemapRequest()
        {
            var request = new DeleteSitemapRequest() { AccessToken = accessToken };
            
            request.AppID = appid;
            request.URL = "https://xxxx.json";

            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestAddMaterialRequest()
        {
            var request = new AddMaterialRequest() { AccessToken = accessToken };
            request.AppID = appid;
            request.ImageURL = "https://xx.png";
            request.Title = "C ???????????????";
            request.Path = "/pages/index/xxx";
            request.Category1Code = "7";
            request.Category2Code = "7000x";

            var result = await request.ExecuteAsync();

            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestModifyMaterialRequest()
        {
            var request = new ModifyMaterialRequest() { AccessToken = accessToken };
            
            request.AppID = appid;
            request.ID = 0;
            request.ImageURL = "https://xxxx.png";
            request.Title = "xxx";
            request.Path = "/pages/index/xxx";
            request.Category1Code = "7";
            request.Category2Code = "7000x";

            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestDeleteMaterialRequest()
        {
            var request = new DeleteMaterialRequest() { };
            request.AccessToken = accessToken;
            request.AppID = appid;
            request.ID = 10160;
            request.Path = "/pages/index/xx";

            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestGetTemplateLibraryListRequest()
        {
            var request = new GetTemplateLibraryListRequest() { };
            request.AccessToken = accessToken;
            request.Offset = 0;
            request.Count = 3;

            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestGetTemplateLibraryByIDRequest()
        {
            var request = new GetTemplateLibraryByIDRequest() { };
            request.AccessToken = accessToken;
            request.ID = "DB0002";

            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestAddTemplateRequest()
        {
            var request = new AddTemplateRequest() { };
            request.AccessToken = accessToken;
            request.ID = "BD00xx";
            request.KeywordIDList = "[1, 2, 3]";

            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestGetTemplateListRequest()
        {
            var request = new GetTemplateListRequest() { };
            request.AccessToken = accessToken;
            request.Offset = 1;
            request.Count = 1;

            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestDeleteTemplateRequest()
        {
            var request = new DeleteTemplateRequest() { };
            request.AccessToken = accessToken;
            request.TemplateID = "xxxxx";

            var result = await request.ExecuteAsync();

            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestSendTemplateMessageRequest()
        {
            var request = new SendTemplateMessageRequest() { };
            request.AccessToken = accessToken;
            request.TemplateID = "xxxxxxxxxx";
            request.TouserOpenID = "xxxxxxxxxxxxxxxxxxx";
            request.Data = "{\"keyword1\": {\"value\": \"2018-09-06\"},\"keyword2\": {\"value\": \"kfc\"}}";
            request.Page = "1";
            request.SceneID = "xxxxx";
            request.SceneType = 1;

            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }
        
        [TestMethod]
        public async Task TestAddCouponBannerRequest()
        {
            var request = new AddCouponBannerRequest() { };
            request.AccessToken = accessToken;
            AddCouponBannerPostData postData = new AddCouponBannerPostData {
                Title = "????????????", // ????????????????????????title??????????????????????????????????????????
                AppRedirectPath = "/test", // ????????????????????????appRedirectPath??????????????????????????????????????????
                CouponID = "8645001234", // ????????????????????????couponId??????????????????????????????????????????
                PicURL = "/index/index", // ????????????????????????picUrl??????????????????????????????????????????
            };

           string postDataStr = JsonConvert.SerializeObject(postData);
           request.jsonBody = postDataStr;

            var result = await request.ExecuteAsync();
            Console.WriteLine(result.Data.BannerID);
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public async Task TestUploadCouponImageRequest()
        {
            var request = new UploadCouponImageRequest() { };
            request.AccessToken = accessToken;
            request.File = "xxxxx";

            var result = await request.ExecuteAsync();
            
            Console.WriteLine("test info: {0}", request.DebugInfo);
            result.ShouldNotBeNull();
        }
    }
}
