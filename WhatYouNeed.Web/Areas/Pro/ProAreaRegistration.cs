﻿//using Microsoft.AspNetCore.Mvc;

//namespace WhatYouNeed.Web.Areas.Pro
//{
//    public class ProAreaRegistration : AreaRegistration 
//    {
//        public override string AreaName 
//        {
//            get 
//            {
//                return "Pro";
//            }
//        }

//        public override void RegisterArea(AreaRegistrationContext context) 
//        {

//            //context.MapRoute(
//            //    "Pro_default",
//            //    "UserPro/{action}/{id}",
//            //   defaults: new { controller = "UserPro", action = "Index", id = UrlParameter.Optional }
//            //   , namespaces: new[] { "WhatYouNeed.Web.Areas.Pro.Controllers" }
//            //);

//            context.MapRoute(
//                "Pro_defaultExt",
//                "Pro/{controller}/{action}/{id}",
//               defaults: new { controller = "UserPro", action = "Index", id = UrlParameter.Optional }
//               , namespaces: new[] { "WhatYouNeed.Web.Areas.Pro.Controllers" }
//            );


//        }
//    }
//}