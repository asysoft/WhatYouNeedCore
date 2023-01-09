using Appli.Model.Enum;
using Appli.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plugin.Payment.Models
{
    public class PaymentSettingModel
    {
        public string StripeClientID { get; set; }

        public string StripeApiKey { get; set; }

        public string StripePublishableKey { get; set; }        

        public Setting Setting { get; set; }
    }
}