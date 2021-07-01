using AutoMapper;
using Compare.BLL.DTOs.CatalogPanel;
using Compare.BLL.DTOs.Product;
using Compare.DAL.Data;
using Compare.DAL.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.CatalogPanel
{
    public class CategoryPanelService : ICategoryPanelService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CategoryPanelService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateCategoryPanelAsync(CreateCategoryPanelDTO modelDTO)
        {
            List<CategoryPanelAndProduct> categoryPanelAndProducts = new List<CategoryPanelAndProduct>();

            CategoryPanel cp = _mapper.Map<CategoryPanel>(modelDTO);
            foreach (int prdId in modelDTO.ProductsId)
            {
                categoryPanelAndProducts.Add(new CategoryPanelAndProduct()
                {
                    CategoryPanelId = cp.Id,
                    ProductId = prdId
                });
            }
            cp.CategoryPanelAndProducts = categoryPanelAndProducts;

            await _dbContext.CategoryPanels.AddAsync(cp);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditCategoryPanelAsync(EditCategoryPanelDTO modelDTO)
        {
            var cp = await _dbContext.CategoryPanels.Include(p => p.CategoryPanelAndProducts).AsSplitQuery()
                .Include(p => p.CategoryPanelTranslates).AsSplitQuery()
                .FirstOrDefaultAsync(p => p.Id == modelDTO.Id);

            cp.CategoryPanelTranslates.Clear();
            cp.CategoryPanelAndProducts.Clear();

            cp.CategoryPanelTranslates = modelDTO.CategoryPanelTranslates
                .Select(p => new CategoryPanelTranslate
                {
                    LanguageCulture = p.LanguageCulture,
                    Name = p.Name,
                    CategoryPanelId = p.CategoryPanelId
                }).ToList();

            cp.CategoryPanelAndProducts = modelDTO.ProductsId
                .Select(p => new CategoryPanelAndProduct
                {
                    ProductId = p,
                    CategoryPanelId = cp.Id
                }).ToList();

            cp.CategoryId = modelDTO.CategoryId;
            cp.DisplayOrder = modelDTO.DisplayOrder;
            cp.IsPublish = modelDTO.IsPublish;

            _dbContext.Update(cp);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<CategoryPanelListDTO> GetAllCategoryPanels()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var pls = _dbContext.CategoryPanels.Include(i => i.Category).ThenInclude(t => t.CategoryTranslates).AsSplitQuery().AsQueryable();
            var result = _dbContext.CategoryPanelTranslates
                .Where(p => p.LanguageCulture == culture).Join(pls, p => p.CategoryPanelId, k => k.Id,
                (p, k) => new CategoryPanelListDTO
                {
                    Id = k.Id,
                    Name = p.Name,
                    CategoryName = k.Category.CategoryTranslates.SingleOrDefault(s => s.LanguageCulture == culture).Name,
                    DisplayOrder = k.DisplayOrder,
                    IsPublish = k.IsPublish
                });
            return result;
        }

        public IEnumerable<CategoryPanelListDTO> GetAllPublishCategoryPanelsByCategoryId(int categoryId)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            List<CategoryPanelListDTO> categoryPanelListDTOs = new List<CategoryPanelListDTO>();

            var cps = _dbContext.CategoryPanels
                .Include(i => i.CategoryPanelAndProducts).ThenInclude(t => t.Product).ThenInclude(t => t.ProductTranslates).AsSplitQuery()
                .Include(i => i.CategoryPanelTranslates).AsSplitQuery()
                .Where(p => p.IsPublish == true && p.CategoryId == categoryId).AsQueryable();

            foreach (var cp in cps)
            {
                var products = new List<ProductDTO>();

                foreach (var product in cp.CategoryPanelAndProducts)
                {
                    products.Add(new ProductDTO()
                    {
                        Id = product.Product.Id,
                        ProductName = product.Product.ProductTranslates.SingleOrDefault(s => s.LanguageCulture == culture).ProductName,
                        Image = product.Product.Image,
                        MinPrice = product.Product.MinPrice,
                        DisplayOrder = product.Product.DisplayOrder
                    });
                }

                categoryPanelListDTOs.Add(new CategoryPanelListDTO()
                {
                    Id = cp.Id,
                    Name = cp.CategoryPanelTranslates.SingleOrDefault(s => s.LanguageCulture == culture).Name,
                    DisplayOrder = cp.DisplayOrder,
                    IsPublish = cp.IsPublish,
                    Products = products
                });
            }

            return categoryPanelListDTOs;
        }

        public async Task<EditCategoryPanelDTO> GetEditCategoryPanelAsync(int id)
        {
            var cp = await _dbContext.CategoryPanels
                .Include(i => i.CategoryPanelTranslates).AsSplitQuery()
                .Include(i => i.CategoryPanelAndProducts).AsSplitQuery()
                .SingleOrDefaultAsync(s => s.Id == id);
            EditCategoryPanelDTO editCategoryPanelDTO = _mapper.Map<EditCategoryPanelDTO>(cp);
            return editCategoryPanelDTO;
        }

        public async Task RemoveCategoryPanelAsync(int id)
        {
            var cp = await _dbContext.CategoryPanels.FindAsync(id);
            _dbContext.CategoryPanels.Remove(cp);
            await _dbContext.SaveChangesAsync();
        }
    }
}
