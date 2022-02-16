using Easy.IO;
using Newtonsoft.Json;
using SmartProgramSDK.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartProgramSDK.Helpers
{
    public class SmartProgramHelper
    {

        /// <summary>
        /// 解密数据 to user entity
        /// </summary>
        /// <param name="sessionKey"></param>
        /// <param name="iv"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public SmartProgramUser DataDecrypt2User(string sessionKey, string iv, string data)
        {
            var result = DataDecrypt(sessionKey, iv, data);
            return JsonConvert.DeserializeObject<SmartProgramUser>(result);
        }

        /// <summary>
        /// 根据百度智能小程序平台提供的解密算法解密数据
        /// </summary>
        /// <param name="sessionKey"></param>
        /// <param name="iv"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public string DataDecrypt(string sessionKey, string iv, string data)
        {
            byte[] aesKey = Base64.Decode(sessionKey);// Convert.FromBase64String(accessToken);
            byte[] ivBt = Base64.Decode(iv);
            byte[] encrypted = Base64.Decode(data);
            byte[] resultArray = null;
            using (RijndaelManaged aes = new RijndaelManaged())
            {
                aes.Key = aesKey;
                aes.IV = ivBt;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                using (ICryptoTransform cTransform = aes.CreateDecryptor())
                {
                    resultArray = cTransform.TransformFinalBlock(encrypted, 0, encrypted.Length);
                }
            }
            ByteBuffer byteBuffer = ByteBuffer.Allocate(resultArray);
            byteBuffer.SetReaderIndex(16);
            var datalen = (int)byteBuffer.ReadUint();
            var result = Encoding.UTF8.GetString(resultArray, 20, datalen);
            var appKey = Encoding.UTF8.GetString(resultArray, 20 + datalen, resultArray.Length - 20 - datalen);
            return result;
        }
    }
}
