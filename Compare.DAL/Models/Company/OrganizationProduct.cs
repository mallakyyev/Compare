using Compare.DAL.Models.Cart;
using Compare.DAL.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Company
{
    public class OrganizationProduct
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        /// <summary>
        /// Id товара организации, который находится в его интернет магазине.
        /// Это поле нужно для редактирования по API запросу
        /// </summary>
        public int? OrganizationProductId { get; set; }

        /// <summary>
        /// URL товара организации, для парсинга информации
        /// </summary>
        public string OrganizationProductUrl { get; set; }

        public int OrganizationId { get; set; }

        public double Price { get; set; }

        /// <summary>
        /// В наличии
        /// </summary>
        public bool InStock { get; set; }

        /// <summary>
        /// Официальный дилер
        /// </summary>
        public bool OfficialDealer { get; set; }

        public Product Product { get; set; }
        public Organization Organization { get; set; }

        public ICollection<Basket> Baskets { get; set; }
    }
}
