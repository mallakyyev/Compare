using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Product
{
    public record ProductTranslateDTO
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public string MetaTitle { get; set; }
        
        public string MetaDescription { get; set; }

        [Required]
        public string LanguageCulture { get; set; }
    }
}
