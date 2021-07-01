using Compare.DAL.Models.Advertising;
using Compare.DAL.Models.Company;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Catalog
{
    public class Category
    {
        public int Id { get; set; }

        public int DisplayOrder { get; set; }

        public bool Published { get; set; }

        public int? ParentCategoryId { get; set; }

        public Category ParentCategory { get; set; }

        public ICollection<Category> Categories { get; set; }

        public ICollection<CategoryTranslate> CategoryTranslates { get; set; }

        public ICollection<CategoryAndProduct> CategoriesAndProducts { get; set; }

        public ICollection<CategoryAndOrganizationApi> CategoriesAndOrganizationApis { get; set; }

        public ICollection<OrganizationSubscription> OrganizationSubscriptions { get; set; }

        public ICollection<Advert> Adverts { get; set; }

        public ICollection<CategoryPanel> CategoryPanels { get; set; }
    }
}
