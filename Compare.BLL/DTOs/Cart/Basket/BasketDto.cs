using Compare.BLL.DTOs.Organization;
using Compare.BLL.DTOs.Product;
using Compare.BLL.DTOs.User;
using Compare.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Cart.Basket
{
    public record BasketDto
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

        public ProductDTO Product { get; set; }

        public ApplicationUserDTO ApplicationUser { get; set; }

        public OrganizationProductDTO OrganizationProduct { get; set; }

        //public OrderOrganization OrderOrganization { get; set; }
    }
}
