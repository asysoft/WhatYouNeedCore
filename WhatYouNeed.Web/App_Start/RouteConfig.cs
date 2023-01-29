using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
//using System.Web.Routing;

namespace WhatYouNeed.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.LowercaseUrls = true;

            routes.MapRoute(
                name: "Page",
                url: "page/{id}",
                defaults: new { controller = "Home", action = "ContentPage", id = UrlParameter.Optional },
                namespaces: new[] { "WhatYouNeed.Web.Controllers" }
            );

            routes.MapRoute(
                    name: "Listings",
                    url: "listings/{id}",
                    defaults: new { controller = "Listing", action = "Listing", id = UrlParameter.Optional },
                    namespaces: new[] { "WhatYouNeed.Web.Controllers" }
                    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WhatYouNeed.Web.Controllers" }
            );

            routes.MapRoute(
                name: "Pro",
                url: "Pro/{controller}/{action}/{id}",
                defaults: new { controller = "UserPro", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WhatYouNeed.Web.Areas.Pro.Controllers" }
                );

        }
    }
}
