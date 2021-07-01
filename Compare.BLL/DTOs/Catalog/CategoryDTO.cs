using Compare.DAL.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Catalog
{
    public record CategoryDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string MetaTitle { get; set; }

        public string MetaDescription { get; set; }

        public int DisplayOrder { get; set; }

        public bool Published { get; set; }

        public int? ParentCategoryId { get; set; }

        public ICollection<CategoryDTO> Categories { get; set; }
    }
}
