using System;
using System.Collections.Generic;

namespace Appli.Model.Models
{
    public partial class Picture : Repository.Pattern.Ef6.Entity
    {
        public Picture()
        {
            this.ListingPictures = new List<ListingPicture>();
            this.AspNetUserImgFiles = new List<UserImgFile>();   
        }

        public int ID { get; set; }
        public string MimeType { get; set; }
        public string SeoFilename { get; set; }
        public virtual ICollection<ListingPicture> ListingPictures { get; set; }
        public virtual ICollection<UserImgFile> AspNetUserImgFiles { get; set; }
    }
}
