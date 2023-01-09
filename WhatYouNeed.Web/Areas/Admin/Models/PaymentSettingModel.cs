using WhatYouNeed.Core.Plugins;
using WhatYouNeed.Model.Enum;
using WhatYouNeed.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatYouNeed.Web.Areas.Admin.Models
{
    public class PaymentSettingModel
    {
        public Setting Setting { get; set; }

        public List<PluginDescriptor> PaymentPlugins { get; set; }
    }
}