using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Organization
{
    public record CreateOrganizationSubscriptionDTO
    {
        /// <summary>
        /// Дата оплаты
        /// </summary>
        [Required]
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        [Required]
        public DateTime ExpireAt { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int OrganizationId { get; set; }
    }
}
