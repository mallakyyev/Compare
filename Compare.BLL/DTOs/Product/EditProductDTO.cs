using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Product
{
    public record EditProductDTO
    {
        public int Id { get; set; }

        public ICollection<ProductTranslateDTO> ProductTranslates { get; set; }

        public ICollection<int> CategoriesId { get; set; }

        [Required]
        public int ManufactureId { get; set; }

        [Required]
        public bool Published { get; set; }

        [Required]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Минимальная цена
        /// </summary>
        public double? MinPrice { get; set; }

        /// <summary>
        /// Максимальная цена
        /// </summary>
        public double? MaxPrice { get; set; }

        /// <summary>
        /// Количество предложений
        /// </summary>
        public int? CountOffers { get; set; }

        public IFormFile FormFile { get; set; }

        public IEnumerable<IFormFile> FormFiles { get; set; }
    }
}
