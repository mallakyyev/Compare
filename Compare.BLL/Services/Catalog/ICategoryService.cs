using Compare.BLL.DTOs.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Catalog
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDTO> GetAllCategory();

        IEnumerable<CategoryDTO> GetAllPublishCategory();

        IEnumerable<CategoryDTO> GetAllPublishCategoryParent();

        IEnumerable<CategoryDTO> GetAllPublishCategoryByParentId(int parentId);

        Task<EditCategoryDTO> GetCategoryAsync(int id);

        Task CreateCategoryAsync(CreateCategoryDTO modelDTO);

        Task EditCategoryAsync(EditCategoryDTO modelDTO);

        Task RemoveCategoryAsync(int id);


        Task<CategoryDTO> GetCategoryDTOAsync(int id);
    }
}
