using Enyim.Caching.Memcached;
using Newtonsoft.Json;
using Seafood.Helper;
using Seafood.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Permissions;
using System.Text;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace Seafood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult KeyOnline()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExecuteKeyOnline(int valueChonmang, int valueCard, string valueTxtuser , string valueTxtpin, string valueTxtseri)
        {
            var result = APIGet2(AppConfigs.api_url, AppConfigs.merchant_id, AppConfigs.api_password, AppConfigs.api_user, valueTxtpin, valueTxtseri, valueChonmang, valueCard);
            return Json(Success_Request(true, result));
        }

        protected DataResponse<TRequest> Success_Request<TRequest>(TRequest data, string mess)
        {
            return new DataResponse<TRequest>()
            {
                Data = data,
                Success = true,
                StatusCode = (int)HttpStatusCode.OK,
                Message = mess
            };
        }
        public string APIGet2(string url, string merchant_id, string api_password, string api_user, string pin, string seri, int card_type, int price_guest)
        {
            try
            {
                var fullUrl = $"{url}?merchant_id={merchant_id}&api_user={api_user}&api_password={api_password}&pin={pin}&seri={seri}&card_type={card_type}&price_guest={price_guest}&note=abc";

                WebRequest request = WebRequest.Create(fullUrl);
                request.Method = "GET";
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        //XmlTextReader reader = new XmlTextReader(stream);
                        StreamReader reader = new StreamReader(stream);

                        string responseString = reader.ReadLine();

                        var result = JsonConvert.DeserializeObject<NapTheResponse>(responseString);
                        if (result == null)
                            return responseString;
                        else
                        {
                            return result.code.GetEnumDescription();
                        }
                    }
                }

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string APIGet(string url, string merchant_id, string api_password,string api_user, string pin, string seri, int card_type, int price_guest)
        {
            try
            {
                var fullUrl = $"{url}?merchant_id={merchant_id}&api_user={api_user}&api_password={api_password}&pin={pin}&seri={seri}&card_type={card_type}&price_guest={price_guest}&note=abc";

                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, fullUrl);
                var content = new StringContent("", null, "text/plain");
                request.Content = content;
                var response =  client.SendAsync(request).Result;
                response.EnsureSuccessStatusCode();
                var responseString = response.Content.ReadAsStringAsync().Result;

                var result = JsonConvert.DeserializeObject<NapTheResponse>(responseString);
                if (result == null)
                    return responseString;
                else
                {
                    return result.code.GetEnumDescription();
                }

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string APIGamebank(String postData, String url, String user, String pwd)
        {
            try
            {
                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(url);
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] data = encoding.GetBytes(postData);
                httpWReq.Method = "POST";
                httpWReq.ContentType = "application/x-www-form-urlencoded";
                httpWReq.ContentLength = data.Length;
                httpWReq.Credentials = new NetworkCredential(user, pwd);
                using (Stream stream = httpWReq.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();
                string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                var result = JsonConvert.DeserializeObject<NapTheResponse>(responseString);
                if(result == null)
                    return responseString;
                else
                {
                    return result.code.GetEnumDescription();
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        protected StatusResponse Success_Request()
        {
            return new StatusResponse()
            {
                Success = true,
                StatusCode = (int)HttpStatusCode.OK,
                Message = "Thành công"
            };
        }

        protected StatusResponse Not_Found(string message = "")
        {
            return new StatusResponse()
            {
                Success = true,
                StatusCode = (int)HttpStatusCode.NotFound,
                Message = string.IsNullOrEmpty(message) ? "Không tìm thấy dữ liệu" : message
            };
        }

        protected StatusResponse Bad_Request(string message = "")
        {
            return new StatusResponse()
            {
                Success = false,
                StatusCode = (int)HttpStatusCode.BadRequest,
                Message = string.IsNullOrEmpty(message) ? "Dữ liệu định dạng sai" : message
            };
        }

        protected StatusResponse Server_Error(string message = "")
        {
            return new StatusResponse()
            {
                Success = false,
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Message = string.IsNullOrEmpty(message) ? "Có lỗi trong quá trình xử lý" : message
            };
        }
    }
}