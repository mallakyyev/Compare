using Compare.DAL.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Company
{
    public class OrganizationSubscription
    {
        public int Id { get; set; }

        /// <summary>
        /// Дата оплаты
        /// </summary>
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime ExpireAt { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
