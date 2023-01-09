using WhatYouNeed.Model.Models;
using GridMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatYouNeed.Web.Models.Grids
{
    public class ListingsGrid : Grid<Listing>
    {
        public ListingsGrid(IQueryable<Listing> items)
            : base(items)
        {
        }
    }
}