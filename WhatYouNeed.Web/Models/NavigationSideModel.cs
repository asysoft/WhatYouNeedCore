using WhatYouNeed.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatYouNeed.Web.Models
{
    public class NavigationSideModel
    {
        public IEnumerable<WhatYouNeed.Web.Extensions.TreeItem<WhatYouNeed.Model.Models.Category>> CategoryTree { get; set; }

        public IEnumerable<ContentPage> ContentPages { get; set; }
    }
}
