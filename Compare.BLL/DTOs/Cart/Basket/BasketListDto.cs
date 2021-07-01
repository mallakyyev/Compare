using Compare.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Cart.Basket
{
    public record BasketListDto
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

        public string ProductName { get; set; }

        public string ApplicationUserId { get; set; }

        public int OrganizationProductId { get; set; }

        public string OrganizationName { get; set; }

        public BasketStatus BasketStatus { get; set; }

        public int? OrderOrganizationId { get; set; }
    }
}
