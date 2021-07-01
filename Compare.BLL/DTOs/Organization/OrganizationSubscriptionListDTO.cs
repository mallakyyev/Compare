using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Organization
{
    public record OrganizationSubscriptionListDTO
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string OrganizationName { get; set; }

        /// <summary>
        /// Дата оплаты
        /// </summary>
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime ExpireAt { get; set; }
    }
}
