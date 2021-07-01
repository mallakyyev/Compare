using Compare.DAL.Models.Catalog;
using Compare.DAL.Models.Company;
using Compare.DAL.Models.Enums;
using Compare.DAL.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Cart
{
    /// <summary>
    /// Корзина товаров
    /// </summary>
    public class Basket
    {
        public int Id { get; set; }

        /// <summary>
        /// Цена товара при офрмлении заказа
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Количество товаров
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Id товара
        /// </summary>
        public int ProductId { get; set; }

        public string ApplicationUserId { get; set; }

        public BasketStatus BasketStatus { get; set; }

        public int OrganizationProductId { get; set; }

        public int? OrderOrganizationId { get; set; }

        public Product Product { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public OrganizationProduct OrganizationProduct { get; set; }

        public OrderOrganization OrderOrganization { get; set; }
    }
}
