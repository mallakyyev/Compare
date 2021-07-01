using Compare.BLL.DTOs.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.OrganizationSubscription
{
    public interface IOrganizationSubscriptionService
    {
        IEnumerable<OrganizationSubscriptionListDTO> GetAllOrganizationSubscriptions();

        IEnumerable<OrganizationSubscriptionListDTO> GetOrganizationSubscriptionsById(int organizationId);

        Task CreateOrganizationSubscriptionAsync(CreateOrganizationSubscriptionDTO modelDTO);

        Task EditOrganizationSubscriptionAsync(EditOrganizationSubscriptionDTO modelDTO);

        Task RemoveOrganizationSubscriptionAsync(int id);

        Task<EditOrganizationSubscriptionDTO> GetOrganizationSubscriptionAsync(int id);

        IEnumerable<OrganizationSubscriptionDTO> GetAllCategoryOrganizationSubscription(int organizationId);
    }
}
