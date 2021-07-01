using Compare.DAL.Models.Company;
using Compare.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Cart
{
    /// <summary>
    /// Заказы для организаций
    /// </summary>
    public class OrderOrganization
    {
        public int Id { get; set; }

        /// <summary>
        /// Id заказа
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Id организации
        /// </summary>
        public int OrganizationId { get; set; }

        /// <summary>
        /// Статус заказа
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        public Order Order { get; set; }

        public Organization Organization { get; set; }

        public ICollection<Basket> Baskets { get; set; }
    }
}
