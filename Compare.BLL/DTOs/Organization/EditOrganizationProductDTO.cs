using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Organization
{
    public record EditOrganizationProductDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        public int? OrganizationProductId { get; set; }

        public string OrganizationProductUrl { get; set; }

        [Required]
        public int OrganizationId { get; set; }

        [Required]
        public double Price { get; set; }

        /// <summary>
        /// В наличии
        /// </summary>
        public bool InStock { get; set; }

        /// <summary>
        /// Официальный дилер
        /// </summary>
        public bool OfficialDealer { get; set; }
    }
}
