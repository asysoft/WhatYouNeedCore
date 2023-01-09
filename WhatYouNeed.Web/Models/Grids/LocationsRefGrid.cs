using WhatYouNeed.Model.Models;
using GridMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatYouNeed.Web.Models.Grids
{
    public class LocationsRefGrid : Grid<LocationRef>
    {
        public LocationsRefGrid(IQueryable<LocationRef> LocationsRef)
            : base(LocationsRef)
        {
        }
    }
}