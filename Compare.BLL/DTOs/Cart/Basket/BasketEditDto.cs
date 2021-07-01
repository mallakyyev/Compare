using Compare.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Cart.Basket
{
    public record BasketEditDto
    {
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Количество товаров
        /// </summary>
        [Required]
        public int Quantity { get; set; }

        /// <summary>
        /// Id товара
        /// </summary>
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int OrganizationProductId { get; set; }

        public int? OrderOrganizationId { get; set; }

        public string ApplicationUserId { get; set; }

        public BasketStatus BasketStatus { get; set; }
    }
}
