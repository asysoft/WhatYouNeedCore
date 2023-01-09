using WhatYouNeed.Model.Models;
using GridMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatYouNeed.Web.Models.Grids
{
    public class ListingModelGrid : Grid<ListingItemModel>
    {
        public ListingModelGrid(IQueryable<ListingItemModel> items)
            : base(items)
        {
        }
    }
}