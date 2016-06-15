using System.Linq;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using UG.Mobile.Framework;
using System.Net.Http.Headers;
using Sync7i.Mobile.Common;
using System.Text;
using System.IO;
using Ionic.Zlib;
namespace Sync7i.Mobile.Agents
{
    #region Base Msg
    public class ErrorCodeJsonConverter : JsonConverter
    {
        #region implemented abstract members of JsonConverter
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var obj = Enum.Parse(typeof(ErrorCode), value.ToString());
            serializer.Serialize(writer, (int)obj);
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Integer)
            {
                var obj = Convert.ToInt32(reader.Value);
                return (ErrorCode)obj;
            }
            else throw new JsonParserException("ErrorCode phải là kiểu int");
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(int) == objectType;//typeof(ErrorCode) == objectType || 
        }

        #endregion
    }

    public class BaseMessage
    {
        public BaseMessage(string publicKey, string signature, ErrorCode errorCode, string errorMsg)
        {
            PublicKey = publicKey;
            Signature = signature;
            ErrorCode = errorCode;
            ErrorMsg = errorMsg;
        }
        public BaseMessage(string publicKey)
        {
            PublicKey = publicKey;
        }
        //JsonConvert.DeserializeObjectAsync not error
        public BaseMessage()
        {
        }
        public static BaseMessage GetBaseMessage(Encryption ex)
        {
            return new BaseMessage("", "", ex.ErrorNumber, ex.ErrorMsg);
        }
        public string MsgJson { get; set; }
        public T GetData<T>() where T : new()
        {
            try
            {
                //T tmp = JsonConvert.DeserializeObject<T>(MsgJson);
                var tmp = (T)JsonConvert.DeserializeObject(MsgJson, typeof(T), new JsonSerializerSettings()
                {
                    MissingMemberHandling = MissingMemberHandling.Error,
                    Error = ErrorHandler
                });
                return tmp;
            }
            catch(Exception ex)
            {
                //TODO
                //log error
                throw new JsonParserException("Lỗi dữ liệu đầu vào hàm. Kiểu dữ liệu PagedPara: " + ex.Message);// (code, msg);  Base Exception header throw new WebServiceException(ex, "Valide Json Object not mask");
            }
        }
        private static void ErrorHandler(object x, Newtonsoft.Json.Serialization.ErrorEventArgs error)
        {
            //throw error.ErrorContext.Error;
            error.ErrorContext.Handled = false;
        }
        public void SetData(object value)
        {
            MsgJson = JsonConvert.SerializeObject(value);
        }
        public string PublicKey { get; set; }
        public string Signature { get; set; }
        [JsonConverter(typeof(ErrorCodeJsonConverter))]
        public ErrorCode ErrorCode { get; set; }
        public string ErrorMsg { get; set; }
    }
    #endregion

    public abstract class AgentBase<T> where T:class, new()
    {
        private static object _lock = new object();
        private static T service;
        public static T Instance
        {
            get
            {
                if (service == null)
                {
                    lock (_lock)
                    {
                        service = new T();
                        return service;
                    }
                }
                return service;
            }
        }
        protected const string ResourceBaseGet = "api/{0}/Get";
        protected const string ResourceBaseGetPagedOlder = "api/{0}/GetPagedOlder";
        protected const string ResourceBaseGetLastest = "api/{0}/GetLastest";
        protected const string ResourceBaseGetCountLastest = "api/{0}/GetCountLastest";
        protected const string ContentType = "application/json";

        static HttpClient httpClient;
        public HttpClient HTTPClient
        {
            get
            {
                if (httpClient == null)
                {
                    httpClient = new HttpClient();
                    httpClient.BaseAddress = new Uri(Sync7iConstants.BaseURL);
                    httpClient.DefaultRequestHeaders.Accept.Add(
                       new MediaTypeWithQualityHeaderValue(ContentType));

                    //// The following line sets a "User-Agent" request header as a default header on the HttpClient instance.
                    //// Default headers will be sent with every request sent from this HttpClient instance.
                    //httpClient.DefaultRequestHeaders.UserAgent.Add(new HttpProductInfoHeaderValue("Sample", "v8"));
                }
                
                return httpClient;
            }
        }
        public async Task<T> GetDataJson<T>(string MsgJson) where T : class, new()
        {
            try
            {
                //T tmp = JsonConvert.DeserializeObject<T>(MsgJson);
				object tmp = JsonConvert.DeserializeObject<T>(MsgJson, new JsonSerializerSettings()
                {
                    MissingMemberHandling = MissingMemberHandling.Error,
                    Error = ErrorHandler
                });
				return (T)tmp;
            }
            catch (Exception ex)
            {
                //TODO
                //log error
                throw new JsonParserException("Lỗi dữ liệu Json: " + ex.Message);// (code, msg);  Base Exception header throw new WebServiceException(ex, "Valide Json Object not mask");
            }
        }
        private static void ErrorHandler(object x, Newtonsoft.Json.Serialization.ErrorEventArgs error)
        {
            //throw error.ErrorContext.Error;
            error.ErrorContext.Handled = false;
        }
        //Use fastest JSON serializer https://github.com/kevin-montrose/Jil Not support .Net porable
        public string SetDataJson(object value)
        {
            return JsonConvert.SerializeObject(value);

            //var msg = string.Empty;
            //using (var output = new StringWriter())
            //{
            //    JSON.Serialize(value, output);
            //    msg = output.ToString();
            //}
            //return msg;
        }
        const string CONTENT_ENCODING = "Content-Encoding";
        const string TOKEN_NAME = "UGToken";
        protected async Task<TResult> ExecuteAsync<TResult>(RequestBase request)
            where TResult : new()
        {
            string publicKey = "";
            BaseMessage msg = new BaseMessage(publicKey);
            msg = PackageDataWWithSecurity(msg, request.Data);

            var data = SetDataJson(msg);

            if (!string.IsNullOrWhiteSpace(request.UGToken))
            {
                if (HTTPClient.DefaultRequestHeaders.Contains(TOKEN_NAME))
                    HTTPClient.DefaultRequestHeaders.Remove(TOKEN_NAME);
                HTTPClient.DefaultRequestHeaders.Add(TOKEN_NAME, request.UGToken);
            }
            var response = new HttpResponseMessage();
            //try
            //{
            if(request.Method==HttpMethod.Post)
                response = await HTTPClient.PostAsync(request.Resource, new StringContent(data, Encoding.UTF8, ContentType));
            else 
            if (request.Method == HttpMethod.Put)
                response = await HTTPClient.PutAsync(request.Resource, new StringContent(data, Encoding.UTF8, ContentType));
            else 
                if (request.Method == HttpMethod.Get)
                    response = await HTTPClient.GetAsync(request.Resource);
            //}
            //catch (HttpRequestException ex)
            //{
            //    throw new HTTPException(System.Net.HttpStatusCode.Unauthorized, ex.Message);
            //}

            if (response.IsSuccessStatusCode)
            {
                string contentStr = string.Empty;

                IEnumerable<string> lst;
                if (response.Content.Headers!=null
                    &&response.Content.Headers.TryGetValues(CONTENT_ENCODING, out lst)
                    && lst.First().ToLower() == "deflate")
                {
                    var bj = await response.Content.ReadAsByteArrayAsync();
                    using (var inStream = new MemoryStream(bj))
                    {
                        using (var bigStreamsss = new DeflateStream(inStream, CompressionMode.Decompress, true))
                        {
                            contentStr = await (new StreamReader(bigStreamsss)).ReadToEndAsync();
                            //using (var bigStreamOut = new MemoryStream())
                            //{
                            //    bigStreamsss.CopyTo(bigStreamOut);
                            //    contentStr = Encoding.UTF8.GetString(bigStreamOut.ToArray(), 0, bigStreamOut.ToArray().Length);
                            //}
                        }

                    }
                }
                else contentStr = await response.Content.ReadAsStringAsync();

                BaseMessage responseContent = await GetDataJson<BaseMessage>(contentStr);
                
                if (responseContent.ErrorCode!=ErrorCode.IsSuccess)
                    throw new BusinessException(responseContent.ErrorCode, responseContent.ErrorMsg);

                CheckPermision(responseContent);

                return responseContent.GetData < TResult>();
            }
            else
            {
                throw new UnknownException(response.StatusCode.ToString());
            }
        }
        protected void CheckPermision(BaseMessage msg)
        {
            if (!string.IsNullOrWhiteSpace(msg.MsgJson))
            {
                string bankPublicKeyReplaced = msg.PublicKey;
                //bankPublicKeyReplaced = bankPublicKeyReplaced.Replace("-----BEGIN CERTIFICATE-----", "");
                //bankPublicKeyReplaced = bankPublicKeyReplaced.Replace("-----END CERTIFICATE-----", "");

                //Kiểm tra PublicKey trong CSDL trung tâm
                //if (Constant.IS_VERIFY_CRL)
                //    if(VerifyCRL(bankPublicKeyReplaced))
                //         throw new WebServiceException("PublicKey không tồn tại trong hệ thống, đề nghị kiểm tra lại!");

                //Giải mã dữ liệu
                string jsonMsg = msg.MsgJson;
                //if (Constant.IS_ENCRYPT)
                //    jsonMsg = UG.Common.RSAEngine.DecryptData(msg.MsgJson);

                //Kiểm tra chữ ký điện tử
                //if (Constant.IS_VERIFY_SIGNATURE)
                //    if(UG.Common.RSAEngine.VerifySignatureHQ(jsonMsg, bankPublicKeyReplaced, msg.Signature))
                //        throw new WebServiceException("Dữ liệu đã bị thay đổi trên đường truyền, đề nghị kiểm tra lại!");
            }
        }
        private bool VerifyCRL(string publicKey)
        {
            bool isPass = true;
            //string serialNumber = GetSerialNumber(publicKey);
            //isPass = LocationStoreBiz.Instance.VerifyCRL(serialNumber);
            return isPass;
        }

        protected BaseMessage PackageDataWWithSecurity(BaseMessage msg, object value)
        {
            msg.ErrorCode = ErrorCode.IsSuccess;
            msg.ErrorMsg = "Thành công";
            if (value == null)
                return msg;
            msg.SetData(value);
            string sign = string.Empty;
            //if (Constant.IS_SIGN)
            //    sign = UG.Common.RSAEngine.SignData(msg.MsgJson);

            //Append sign vao xmlMsg
            msg.Signature = sign;

            string bankPublicKeyReplaced = msg.PublicKey;
            //bankPublicKeyReplaced = bankPublicKeyReplaced.Replace("-----BEGIN CERTIFICATE-----", "");
            //bankPublicKeyReplaced = bankPublicKeyReplaced.Replace("-----END CERTIFICATE-----", "");
            ////Bat dau ma hoa message
            //if (Constant.IS_ENCRYPT)
            //    msg.MsgXML = RSAEngine.EncryptDataHQ(msg.MsgJson, bankPublicKeyReplaced);

            //Set publicKey Center
            //msg.PublicKey = GetPublicKey();

            return msg;
        }
    }
}
