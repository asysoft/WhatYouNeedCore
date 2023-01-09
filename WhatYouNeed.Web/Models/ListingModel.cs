using WhatYouNeed.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatYouNeed.Web.Models
{
    public class ListingModel
    {
        public WhatYouNeed.Web.Models.Grids.ListingsGrid Grid { get; set; }

        public List<ListingItemModel> Listings { get; set; }

        public List<Category> Categories { get; set; }
    }
}