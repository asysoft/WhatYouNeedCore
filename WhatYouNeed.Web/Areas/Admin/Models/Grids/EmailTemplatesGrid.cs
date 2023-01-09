using WhatYouNeed.Model.Models;
using GridMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatYouNeed.Web.Areas.Admin.Models
{
    public class EmailTemplatesGrid : Grid<EmailTemplate>
    {
        public EmailTemplatesGrid(IQueryable<EmailTemplate> emailTemplate)
            : base(emailTemplate)
        {
        }
    }
}