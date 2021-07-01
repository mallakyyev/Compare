using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Advertising
{
    public class AdvertTranslate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LanguageCulture { get; set; }

        public int AdvertId { get; set; }

        public Advert Advert { get; set; }
    }
}
