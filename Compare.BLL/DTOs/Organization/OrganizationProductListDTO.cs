using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Organization
{
    public record OrganizationProductListDTO
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int OrganizationId { get; set; }

        public int? OrganizationProductId { get; set; }

        public string OrganizationProductUrl { get; set; }

        public string OrganizationName { get; set; }

        public string OrganizationLogo { get; set; }

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
