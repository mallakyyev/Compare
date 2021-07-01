using Compare.DAL.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Company
{
    public class CategoryAndOrganizationApi
    {
        public int CategoryId { get; set; }
        public int OrganizationApiId { get; set; }

        public Category Category { get; set; }
        public OrganizationApi OrganizationApi { get; set; }
    }
}
