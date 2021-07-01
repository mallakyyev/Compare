using Compare.BLL.DTOs.Product;
using Compare.BLL.DTOs.ProductAttributeTemplate;
using Compare.BLL.DTOs.ProductOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.ProductAttributeTemplate
{
    public interface IProductAttributeTemplateService
    {
        IEnumerable<ProductAttributeTemplateListDTO> GetAllProductAttributeTemplates();

        Task CreateProductAttributeTemplateAsync(CreateProductAttributeTemplateDTO modelDTO);

        Task EditProductAttributeTemplateAsync(EditProductAttributeTemplateDTO modelDTO);

        Task RemoveProductAttributeTemplateAsync(int id);

        Task<EditProductAttributeTemplateDTO> GetEditProductAttributeTemplateAsync(int id);

        IEnumerable<ProductOptionCultureDTO> GetProductOptionsCultureListId(int id);
    }
}
