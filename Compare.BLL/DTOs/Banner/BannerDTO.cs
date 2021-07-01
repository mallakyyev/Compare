using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Banner
{
    public record BannerDTO
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Link { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsPublish { get; set; }

        public ICollection<BannerTranslateDTO> BannerTranslates { get; set; }
    }
}
