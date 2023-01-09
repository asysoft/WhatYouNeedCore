using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WhatYouNeed.Web.Models
{
    public class TextFileModel
    {
        [AllowHtml]
        public string Text { get; set; }
    }
}