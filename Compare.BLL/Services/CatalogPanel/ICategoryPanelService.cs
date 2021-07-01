using Compare.BLL.DTOs.CatalogPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.CatalogPanel
{
    public interface ICategoryPanelService
    {
        IEnumerable<CategoryPanelListDTO> GetAllCategoryPanels();

        Task CreateCategoryPanelAsync(CreateCategoryPanelDTO modelDTO);

        Task EditCategoryPanelAsync(EditCategoryPanelDTO modelDTO);

        Task RemoveCategoryPanelAsync(int id);

        Task<EditCategoryPanelDTO> GetEditCategoryPanelAsync(int id);


        IEnumerable<CategoryPanelListDTO> GetAllPublishCategoryPanelsByCategoryId(int categoryId);
    }
}
