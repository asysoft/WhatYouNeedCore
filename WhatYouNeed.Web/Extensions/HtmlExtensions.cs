using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
//using System.Web.Mvc.Html;

namespace WhatYouNeed.Web.Extensions
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString DoAction(this HtmlHelper helper, string hookName, object additionalData = null)
        {
            return helper.Action("DoAction", "Hook", new { hookName = hookName, additionalData = additionalData, area = "" });
        }
    }
}