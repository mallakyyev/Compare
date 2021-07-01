using Compare.BLL.DTOs.Organization;
using Compare.DAL.Models.Company;
using Compare.DAL.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Organization
{
    public interface IOrganizationService
    {
        IEnumerable<OrganizationDTO> GetAllOrganizations();

        Task CreateOrganizationAsync(CreateOrganizationDTO modelDTO);

        Task EditOrganizationAsync(EditOrganizationDTO modelDTO);

        Task RemoveOrganizationAsync(int id);

        Task<EditOrganizationDTO> GetOrganizationAsync(int id);

        Task<OrganizationDTO> GetOrganizationDetailAsync(int storeId);


        /// <summary>
        /// OrganizationApi
        /// </summary>
        /// <returns></returns>
        IEnumerable<OrganizationApiDTO> GetAllApiOrganizations();

        Task CreateOrganizationApiAsync(CreateOrganizationApiDTO modelDTO);

        Task EditOrganizationApiAsync(EditOrganizationApiDTO modelDTO);

        Task RemoveOrganizationApiAsync(int id);

        Task<EditOrganizationApiDTO> GetOrganizationApiAsync(int id);

        IEnumerable<OrganizationApi> GetOrganizationApiList();


        /// <summary>
        /// ProductAndOrganization
        /// </summary>
        /// <returns></returns>
        IEnumerable<OrganizationProductListDTO> GetAllOrganizationProducts();

        IEnumerable<OrganizationProductListDTO> GetOrganizationProducts(int organizationId);

        Task CreateOrganizationProductAsync(CreateOrganizationProductDTO modelDTO);

        Task EditOrganizationProductAsync(EditOrganizationProductDTO modelDTO);

        Task EditOrganizationProductPriceAsync(int organizationId, int organizationProductId, double price, bool inStock);

        Task RemoveOrganizationProductAsync(int id, ApplicationUser user);

        Task<EditOrganizationProductDTO> GetOrganizationProductAsync(int id);


        IEnumerable<CategoryOrganizationApiListDTO> GetUrlCategoryOrganizationApiList(int categoryId);
    }
}
