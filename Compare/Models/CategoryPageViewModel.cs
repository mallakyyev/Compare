using Compare.BLL.DTOs.Catalog;
using Compare.BLL.DTOs.CatalogPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Models
{
    public class CategoryPageViewModel
    {
        public IEnumerable<CategoryDTO> CategoryList { get; set; }

        public IEnumerable<CategoryPanelListDTO> CategoryPanelList { get; set; }
    }
}
