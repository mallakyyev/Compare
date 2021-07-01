using AutoMapper;
using Compare.BLL.DTOs.Organization;
using Compare.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using organizationSubscription = Compare.DAL.Models.Company;

namespace Compare.BLL.Services.OrganizationSubscription
{
    public class OrganizationSubscriptionService : IOrganizationSubscriptionService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public OrganizationSubscriptionService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateOrganizationSubscriptionAsync(CreateOrganizationSubscriptionDTO modelDTO)
        {
            organizationSubscription.OrganizationSubscription orgSub = _mapper.Map<organizationSubscription.OrganizationSubscription>(modelDTO);
            _dbContext.OrganizationSubscriptions.Add(orgSub);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditOrganizationSubscriptionAsync(EditOrganizationSubscriptionDTO modelDTO)
        {
            organizationSubscription.OrganizationSubscription orgSub = _mapper.Map<organizationSubscription.OrganizationSubscription>(modelDTO);
            _dbContext.OrganizationSubscriptions.Update(orgSub);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<OrganizationSubscriptionListDTO> GetAllOrganizationSubscriptions()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            List<OrganizationSubscriptionListDTO> result = new List<OrganizationSubscriptionListDTO>();
            
            var getList = GetList().AsQueryable();
            foreach (var list in getList)
            {
                result.Add(new OrganizationSubscriptionListDTO()
                {
                    Id = list.Id,
                    CategoryName = list.Category.CategoryTranslates.SingleOrDefault(s => s.LanguageCulture == culture).Name,
                    OrganizationName = list.Organization.Name,
                    PaymentDate = list.PaymentDate,
                    ExpireAt = list.ExpireAt
                });
            }

            return result;
        }

        public IEnumerable<OrganizationSubscriptionListDTO> GetOrganizationSubscriptionsById(int organizationId)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            List<OrganizationSubscriptionListDTO> result = new List<OrganizationSubscriptionListDTO>();

            var getList = _dbContext.OrganizationSubscriptions
                .Include(i => i.Category).ThenInclude(t => t.CategoryTranslates).AsSplitQuery()
                .Include(i => i.Organization).AsSplitQuery()
                .Where(p => p.OrganizationId == organizationId).AsQueryable().ToList();
            foreach (var list in getList)
            {
                result.Add(new OrganizationSubscriptionListDTO()
                {
                    Id = list.Id,
                    CategoryName = list.Category.CategoryTranslates.SingleOrDefault(s => s.LanguageCulture == culture).Name,
                    OrganizationName = list.Organization.Name,
                    PaymentDate = list.PaymentDate,
                    ExpireAt = list.ExpireAt
                });
            }

            return result;
        }

        public async Task<EditOrganizationSubscriptionDTO> GetOrganizationSubscriptionAsync(int id)
        {
            organizationSubscription.OrganizationSubscription orgSub = await _dbContext.OrganizationSubscriptions.FindAsync(id);
            EditOrganizationSubscriptionDTO editOrganizationSubscriptionDTO = _mapper.Map<EditOrganizationSubscriptionDTO>(orgSub);
            return editOrganizationSubscriptionDTO;
        }

        public async Task RemoveOrganizationSubscriptionAsync(int id)
        {
            organizationSubscription.OrganizationSubscription orgSub = await _dbContext.OrganizationSubscriptions.FindAsync(id);

            _dbContext.OrganizationSubscriptions.Remove(orgSub);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<organizationSubscription.OrganizationSubscription> GetList()
        {
            var orgSub = _dbContext.OrganizationSubscriptions
                .Include(i => i.Category).ThenInclude(t => t.CategoryTranslates).AsSplitQuery()
                .Include(i => i.Organization).AsSplitQuery().ToList();
            return orgSub;
        }

        public IEnumerable<OrganizationSubscriptionDTO> GetAllCategoryOrganizationSubscription(int organizationId)
        {
            var organizationSubscriptions = _dbContext.OrganizationSubscriptions
                .Where(p => p.OrganizationId == organizationId && p.PaymentDate <= DateTime.Now.Date 
                && p.ExpireAt >= DateTime.Now.Date);

            var organizationSubscriptionDTOs = _mapper.Map<IEnumerable<OrganizationSubscriptionDTO>>(organizationSubscriptions);

            return organizationSubscriptionDTOs;
        }
    }
}
