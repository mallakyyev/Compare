using AutoMapper;
using Compare.BLL.DTOs.Organization;
using Compare.BLL.Services.Checking;
using Compare.DAL.Data;
using Compare.DAL.Models.Company;
using Compare.DAL.Models.User;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using organization = Compare.DAL.Models.Company;

namespace Compare.BLL.Services.Organization
{
    public class OrganizationService : IOrganizationService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ICheckingService _checkingService;

        private const string imagPath = "/images/organizations/";

        public OrganizationService(ApplicationDbContext dbContext, IMapper mapper, IHostingEnvironment appEnvironment,
            UserManager<ApplicationUser> userManager, ICheckingService checkingService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _appEnvironment = appEnvironment;
            _userManager = userManager;
            _checkingService = checkingService;
        }

        public async Task CreateOrganizationAsync(CreateOrganizationDTO modelDTO)
        {
            organization.Organization org = _mapper.Map<organization.Organization>(modelDTO);
            if (modelDTO.FormFile != null)
            {
                string fileName = await ImageService.UploadImage(modelDTO.FormFile, imagPath, _appEnvironment);
                org.Logo = fileName;
            }
            await _dbContext.Organizations.AddAsync(org);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditOrganizationAsync(EditOrganizationDTO modelDTO)
        {
            organization.Organization org = _mapper.Map<organization.Organization>(modelDTO);
            if (modelDTO.FormFile != null)
            {
                ImageService.DeleteImage(org.Logo, imagPath, _appEnvironment);

                string fileName = await ImageService.UploadImage(modelDTO.FormFile, imagPath, _appEnvironment);
                org.Logo = fileName;
            }
            _dbContext.Organizations.Update(org);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<OrganizationDTO> GetAllOrganizations()
        {
            var organizationDTOs = _mapper.Map<IEnumerable<organization.Organization>, IEnumerable<OrganizationDTO>>(GetList().AsQueryable());
            return organizationDTOs;
        }

        public async Task<EditOrganizationDTO> GetOrganizationAsync(int id)
        {
            organization.Organization org = await _dbContext.Organizations.FindAsync(id);
            EditOrganizationDTO editOrganizationDTO = _mapper.Map<EditOrganizationDTO>(org);
            return editOrganizationDTO;
        }

        public async Task RemoveOrganizationAsync(int id)
        {
            organization.Organization org = await _dbContext.Organizations.FindAsync(id);
            if (!string.IsNullOrEmpty(org.Logo))
            {
                ImageService.DeleteImage(org.Logo, imagPath, _appEnvironment);
            }
            _dbContext.Organizations.Remove(org);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<OrganizationDTO> GetOrganizationDetailAsync(int storeId)
        {
            var org = await _dbContext.Organizations
                .Include(i => i.StoreComments.Where(p => p.IsPublish == true)).AsSplitQuery()
                .FirstOrDefaultAsync(s => s.Id == storeId);
            OrganizationDTO organizationDTO = _mapper.Map<OrganizationDTO>(org);

            return organizationDTO;
        }

        public IEnumerable<organization.Organization> GetList()
        {
            var organizations = _dbContext.Organizations.ToList();
            return organizations;
        }


        /// <summary>
        /// CRUD OrganizationAPI
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OrganizationApiDTO> GetAllApiOrganizations()
        {
            var organizationApiDTOs = _mapper.Map<IEnumerable<OrganizationApi>, IEnumerable<OrganizationApiDTO>>(GetOrganizationApiList().AsQueryable());
            return organizationApiDTOs;
        }

        public async Task CreateOrganizationApiAsync(CreateOrganizationApiDTO modelDTO)
        {
            List<CategoryAndOrganizationApi> categoryAndOrganizationApis = new List<CategoryAndOrganizationApi>();

            OrganizationApi org = _mapper.Map<OrganizationApi>(modelDTO);
            foreach (int catId in modelDTO.CategoriesId)
            {
                categoryAndOrganizationApis.Add(new CategoryAndOrganizationApi()
                {
                    CategoryId = catId,
                    OrganizationApiId = org.Id
                });
            }
            org.CategoriesAndOrganizationApis = categoryAndOrganizationApis;

            await _dbContext.OrganizationApis.AddAsync(org);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditOrganizationApiAsync(EditOrganizationApiDTO modelDTO)
        {
            var organizationApi = await _dbContext.OrganizationApis.Include(p => p.CategoriesAndOrganizationApis)
                .FirstOrDefaultAsync(p => p.Id == modelDTO.Id);

            organizationApi.CategoriesAndOrganizationApis.Clear();

            organizationApi.CategoriesAndOrganizationApis = modelDTO.CategoriesId
                .Select(p => new CategoryAndOrganizationApi
                {
                    OrganizationApiId = organizationApi.Id,
                    CategoryId = p
                }).ToList();

            organizationApi.Name = modelDTO.Name;
            organizationApi.OrganizationId = modelDTO.OrganizationId;
            organizationApi.UrlApi = modelDTO.UrlApi;

            _dbContext.Update(organizationApi);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveOrganizationApiAsync(int id)
        {
            OrganizationApi organizationApi = await _dbContext.OrganizationApis.FindAsync(id);
            
            _dbContext.OrganizationApis.Remove(organizationApi);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<EditOrganizationApiDTO> GetOrganizationApiAsync(int id)
        {
            OrganizationApi organizationApi = await _dbContext.OrganizationApis.Include(i => i.CategoriesAndOrganizationApis)
                .SingleOrDefaultAsync(s => s.Id == id);
            EditOrganizationApiDTO editOrganizationApiDTO = _mapper.Map<EditOrganizationApiDTO>(organizationApi);
            return editOrganizationApiDTO;
        }

        public IEnumerable<OrganizationApi> GetOrganizationApiList()
        {
            var organizationApis = _dbContext.OrganizationApis.Include(i => i.CategoriesAndOrganizationApis).ToList();
            return organizationApis;
        }




        /// <summary>
        /// Organization product
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OrganizationProductListDTO> GetAllOrganizationProducts()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            
            var organizationProductListDTOs = new List<OrganizationProductListDTO>();

            var organizationProducts = GetOrganizationProductList().AsQueryable();
            foreach(var orgProd in organizationProducts)
            {
                organizationProductListDTOs.Add(new OrganizationProductListDTO() { 
                    Id = orgProd.Id,
                    ProductName = orgProd.Product.ProductTranslates.SingleOrDefault(s => s.LanguageCulture == culture).ProductName,
                    OrganizationProductId = orgProd.OrganizationProductId,
                    OrganizationProductUrl = orgProd.OrganizationProductUrl,
                    OrganizationName = orgProd.Organization.Name,
                    Price = orgProd.Price,
                    InStock = orgProd.InStock,
                    OfficialDealer = orgProd.OfficialDealer
                });
            }
            
            return organizationProductListDTOs;
        }

        public IEnumerable<OrganizationProductListDTO> GetOrganizationProducts(int organizationId)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

            var organizationProductListDTOs = new List<OrganizationProductListDTO>();

            var organizationProducts = _dbContext.OrganizationProducts.Where(p => p.OrganizationId == organizationId)
                .Include(i => i.Product).ThenInclude(t => t.ProductTranslates).AsSplitQuery()
                .Include(i => i.Organization).AsSplitQuery().AsQueryable();
            foreach (var orgProd in organizationProducts)
            {
                organizationProductListDTOs.Add(new OrganizationProductListDTO()
                {
                    Id = orgProd.Id,
                    ProductName = orgProd.Product.ProductTranslates.SingleOrDefault(s => s.LanguageCulture == culture).ProductName,
                    OrganizationProductId = orgProd.OrganizationProductId,
                    OrganizationProductUrl = orgProd.OrganizationProductUrl,
                    OrganizationName = orgProd.Organization.Name,
                    Price = orgProd.Price
                });
            }

            return organizationProductListDTOs;
        }

        public async Task CreateOrganizationProductAsync(CreateOrganizationProductDTO modelDTO)
        {
            OrganizationProduct organizationProduct = _mapper.Map<OrganizationProduct>(modelDTO);
            await _dbContext.OrganizationProducts.AddAsync(organizationProduct);
            await _dbContext.SaveChangesAsync();

            await _checkingService.CheckMinMaxPriceProductById(modelDTO.ProductId);
        }

        public async Task EditOrganizationProductAsync(EditOrganizationProductDTO modelDTO)
        {
            OrganizationProduct organizationProduct = _mapper.Map<OrganizationProduct>(modelDTO);
            _dbContext.OrganizationProducts.Update(organizationProduct);
            await _dbContext.SaveChangesAsync();

            await _checkingService.CheckMinMaxPriceProductById(modelDTO.ProductId);
        }

        public async Task EditOrganizationProductPriceAsync(int organizationId, int organizationProductId, double price, bool inStock)
        {
            var organizationProduct = await _dbContext.OrganizationProducts.SingleOrDefaultAsync(s => s.OrganizationId == organizationId && s.OrganizationProductId == organizationProductId);
            if(organizationProduct != null)
            {
                organizationProduct.Price = price;
                organizationProduct.InStock = inStock;
                _dbContext.OrganizationProducts.Update(organizationProduct);
                await _dbContext.SaveChangesAsync();

                await _checkingService.CheckMinMaxPriceProductById(organizationProduct.ProductId);
            }
        }

        public async Task RemoveOrganizationProductAsync(int id, ApplicationUser user)
        {
            var role = await _userManager.IsInRoleAsync(user, "Admin");
            OrganizationProduct organizationProduct = await _dbContext.OrganizationProducts.FindAsync(id);
            if (organizationProduct.OrganizationId == user.OrganizationId || role)
            {
                _dbContext.OrganizationProducts.Remove(organizationProduct);
                await _dbContext.SaveChangesAsync();

                await _checkingService.CheckMinMaxPriceProductById(organizationProduct.ProductId);
            }
        }

        public async Task<EditOrganizationProductDTO> GetOrganizationProductAsync(int id)
        {
            OrganizationProduct organizationProduct = await _dbContext.OrganizationProducts.FindAsync(id);
            EditOrganizationProductDTO organizationProductDTO = _mapper.Map<EditOrganizationProductDTO>(organizationProduct);
            return organizationProductDTO;
        }

        public IEnumerable<OrganizationProduct> GetOrganizationProductList()
        {
            var organizationProducts = _dbContext.OrganizationProducts
                .Include(i => i.Product).ThenInclude(t => t.ProductTranslates).AsSplitQuery()
                .Include(i => i.Organization).AsSplitQuery();
            return organizationProducts;
        }



        public IEnumerable<CategoryOrganizationApiListDTO> GetUrlCategoryOrganizationApiList(int categoryId)
        {
            List<CategoryOrganizationApiListDTO> categoryOrganizationApiListDTOs = new List<CategoryOrganizationApiListDTO>();
            var catOrgApi = _dbContext.CategoriesAndOrganizationApis.Include(i => i.OrganizationApi).AsSplitQuery()
                .Where(p => p.CategoryId == categoryId);
            foreach(var orgApi in catOrgApi)
            {
                categoryOrganizationApiListDTOs.Add(new CategoryOrganizationApiListDTO()
                {
                    CategoryId = orgApi.CategoryId,
                    OrganizationApiId = orgApi.OrganizationApiId,
                    UrlApi = orgApi.OrganizationApi.UrlApi
                });
            }

            return categoryOrganizationApiListDTOs;
        }
    }
}
