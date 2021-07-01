using Compare.DAL.Models.Catalog;
using Compare.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Advertising
{
    public class Advert
    {
        public int Id { get; set; }

        public AdvertPlaceStatus AdvertPlaceStatus { get; set; }

        public PagePlaceStatus PagePlaceStatus { get; set; }

        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public string Image { get; set; }

        public string Link { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsPublish { get; set; }

        public ICollection<AdvertTranslate> AdvertTranslates { get; set; }
    }
}
