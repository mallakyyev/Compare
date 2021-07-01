using Compare.BLL.DTOs.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Organization
{
    public record OrganizationSubscriptionDTO
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

        public CategoryDTO Category { get; set; }

        public int OrganizationId { get; set; }

        public OrganizationDTO Organization { get; set; }
    }
}
