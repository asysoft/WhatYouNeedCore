using WhatYouNeed.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
//using System.Web.Routing;

namespace WhatYouNeed.Web.Controllers
{
    public class HookController : Controller
    {
        #region Fields

        private readonly IHookService _hookService;        

        #endregion

        #region Constructors

        public HookController(IHookService hookService)
        {
            this._hookService = hookService;            
        }

        #endregion

        #region Methods

        [ChildActionOnly]
        public ActionResult DoAction(string hookName, object additionalData = null)
        {                                  
            var routeDataList = new List<RouteValueDictionary>();

            var hooks = _hookService.LoadActiveHooksByName(hookName);
            foreach (var hook in hooks)
            {
                var hookRouteData = new RouteValueDictionary();

                RouteValueDictionary routeValues = hook.GetRoute(hookName);                
                hookRouteData = routeValues;
                hookRouteData.Add("additionalData", additionalData);

                routeDataList.Add(hookRouteData);
            }

            return PartialView(routeDataList);
        }

        #endregion
    }
}