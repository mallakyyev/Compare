using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Home
{
    public class Banner
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Link { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsPublish { get; set; }

        public ICollection<BannerTranslate> BannerTranslates { get; set; }
    }
}
