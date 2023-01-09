﻿using WhatYouNeed.Web.ActionFilters;
using System.Web;
using System.Web.Mvc;

namespace WhatYouNeed.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ElmahErrorMVCAttribute());
        }
    }
}