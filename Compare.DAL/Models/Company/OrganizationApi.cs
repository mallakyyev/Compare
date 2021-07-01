using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Company
{
    public class OrganizationApi
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int OrganizationId { get; set; }

        public string UrlApi { get; set; }

        public Organization Organization { get; set; }

        public ICollection<CategoryAndOrganizationApi> CategoriesAndOrganizationApis { get; set; }
    }
}
