using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Banner
{
    public record EditBannerDTO
    {
        [Required]
        public int Id { get; set; }

        public string Image { get; set; }

        public string Link { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

        [Required]
        public DateTime DateEnd { get; set; }

        [Required]
        public int DisplayOrder { get; set; }

        [Required]
        public bool IsPublish { get; set; }

        public ICollection<BannerTranslateDTO> BannerTranslates { get; set; }

        [Required]
        public IFormFile FormFile { get; set; }
    }
}
