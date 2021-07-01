using Compare.BLL.DTOs.Bookmarks;
using Compare.BLL.DTOs.Commentary.ProductCommentary;
using Compare.BLL.DTOs.Organization;
using Compare.BLL.DTOs.ProductDetailAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Product
{
    public record ProductDTO
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string MetaTitle { get; set; }

        public string MetaDescription { get; set; }

        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public string Image { get; set; }

        public bool Published { get; set; }

        public int DisplayOrder { get; set; }

        public int ManufactureId { get; set; } = 0;

        public string ManufactureName { get; set; }

        public int? ProductDetailAttributeId { get; set; }

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

        public bool InBookmark { get; set; } = false;

        public ProductDetailAttributeDTO ProductDetailAttribute { get; set; }


        /// <summary>
        /// Поля не относящие к классу
        /// </summary>
        //public double PriceMin { get; set; }

        //public double PriceMax { get; set; }

        //public int CountSubsciption { get; set; }

        public ICollection<OrganizationProductDTO> OrganizationProducts { get; set; }

        public ICollection<ProductMediaDTO> ProductMedias { get; set; }

        public ICollection<ProductDetailAttributeListDTO> ProductDetailAttributeList { get; set; }

        public ICollection<ProductCommentListDto> ProductComments { get; set; }

        public ICollection<BookmarkDto> Bookmarks { get; set; }
    }
}
