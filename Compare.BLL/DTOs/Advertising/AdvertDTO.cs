using Compare.BLL.DTOs.Catalog;
using Compare.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Advertising
{
    public record AdvertDTO
    {
        public int Id { get; set; }

        public AdvertPlaceStatus AdvertPlaceStatus { get; set; }

        public PagePlaceStatus PagePlaceStatus { get; set; }

        public int? CategoryId { get; set; }

        public CategoryDTO Category { get; set; }

        public string Image { get; set; }

        public string Link { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsPublish { get; set; }

        public ICollection<AdvertTranslateDTO> AdvertTranslates { get; set; }
    }
}
