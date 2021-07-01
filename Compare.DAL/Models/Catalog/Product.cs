using Compare.DAL.Models.Bookmarks;
using Compare.DAL.Models.Commentary;
using Compare.DAL.Models.Company;
using Compare.DAL.Models.Home;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Catalog
{
    public class Product
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public bool Published { get; set; }

        public int ManufactureId { get; set; }

        public int DisplayOrder { get; set; }

        public Manufacture Manufacture { get; set; }

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

        public ProductDetailAttribute ProductDetailAttribute { get; set; }

        public ICollection<ProductTranslate> ProductTranslates { get; set; }

        public ICollection<CategoryAndProduct> CategoriesAndProducts { get; set; }

        public ICollection<OrganizationProduct> OrganizationProducts { get; set; }

        public ICollection<ProductMedia> ProductMedias { get; set; }

        public ICollection<PanelAndProduct> PanelAndProducts { get; set; }

        public ICollection<CategoryPanelAndProduct> CategoryPanelAndProducts { get; set; }

        public ICollection<ProductComment> ProductComments { get; set; }

        public ICollection<Bookmark> Bookmarks { get; set; }
    }
}
