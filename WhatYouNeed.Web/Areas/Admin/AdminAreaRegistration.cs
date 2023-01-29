////using System.Web.Mvc;
//using Microsoft.AspNetCore.Mvc;

//namespace WhatYouNeed.Web.Areas.Admin
//{
//    [Area("Admin")]
//    public class AdminAreaRegistration  //: AreaRegistration
//    {
//        public override string AreaName
//        {
//            get
//            {
//                return "Admin";
//            }
//        }

//        public override void RegisterArea(AreaRegistrationContext context)
//        {
//            context.MapRoute(
//                name: "Install",
//                url: "install",
//                defaults: new { controller = "Install", action = "Index", id = UrlParameter.Optional },
//                namespaces: new[] { "WhatYouNeed.Web.Areas.Admin.Controllers" }
//            );

//            context.MapRoute(
//                "Admin",
//                "Admin",
//                new { action = "Index", controller = "Manage" },
//                namespaces: new[] { "WhatYouNeed.Web.Areas.Admin.Controllers" }
//            );

//            context.MapRoute(
//                "Admin_default",
//                "Admin/{controller}/{action}/{id}",
//                new {  id = UrlParameter.Optional },
//                namespaces: new[] { "WhatYouNeed.Web.Areas.Admin.Controllers" }
//            );


//        }
//    }
//}