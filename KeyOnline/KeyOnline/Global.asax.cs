﻿using Seafood.Helper;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Seafood
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AppConfigs.ReadConfigs();
        }

        //protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        //{
        //    if (HttpContext.Current.User != null)
        //    {
        //        var uri = ConfigurationManager.AppSettings["ApiEndPoint"] + ApiUri.POST_AccountIsAuthori;
        //        string token = "";
        //        Uri urlapi = new Uri(uri);
        //        using (var wc = new HttpClient())
        //        {
        //            wc.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        //            var jsonResult = wc.GetAsync($@"{urlapi}").Result.Content.ReadAsStringAsync().Result;
        //            var result = JsonConvert.DeserializeObject<ResponseBase<bool>>(jsonResult);
        //            if(result == null || result.StatusCode == (int)HttpStatusCode.Unauthorized)
        //            {
        //                RemoteFormsIdentity();
        //            }    
        //        }

        //    }
        //}

        //private void RemoteFormsIdentity()
        //{
        //    FormsAuthentication.SignOut();
        //    HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, "");
        //    if(cookie != null)
        //    {
        //        cookie.Expires = DateTime.Now.AddYears(-1);
        //        Response.Cookies.Add(cookie);
        //    }     
        //}
    }
}
