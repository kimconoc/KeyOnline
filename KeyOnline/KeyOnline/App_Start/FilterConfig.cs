﻿using System.Web;
using System.Web.Mvc;

namespace Seafood
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute {
                View = "_Error"
            });
        }
    }
}
