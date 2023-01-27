﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appli.Model.Models
{
    public partial class UserImgFile : Repository.Pattern.Ef6.Entity
    {

        [Key]
        [Column(Order = 0)]
        [ForeignKey("AspNetUser")]
        public string AspNetUserId { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Picture")]
        public int PictureID { get; set; }

        public int Ordering { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Picture Picture { get; set; }
    }
}
