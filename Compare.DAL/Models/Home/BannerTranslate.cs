using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Home
{
    public class BannerTranslate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LanguageCulture { get; set; }

        public int BannerId { get; set; }

        public Banner Banner { get; set; }
    }
}
