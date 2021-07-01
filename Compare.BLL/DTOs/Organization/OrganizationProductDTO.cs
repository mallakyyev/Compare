using Compare.BLL.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Organization
{
    public record OrganizationProductDTO
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int OrganizationId { get; set; }

        public int? OrganizationProductId { get; set; }

        public string OrganizationProductUrl { get; set; }

        public double Price { get; set; }

        /// <summary>
        /// В наличии
        /// </summary>
        public bool InStock { get; set; }

        /// <summary>
        /// Официальный дилер
        /// </summary>
        public bool OfficialDealer { get; set; }

        public ProductDTO Product { get; set; }
        public OrganizationDTO Organization { get; set; }
    }
}
