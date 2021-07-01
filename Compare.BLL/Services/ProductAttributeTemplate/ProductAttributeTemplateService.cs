using AutoMapper;
using Compare.BLL.DTOs.Product;
using Compare.BLL.DTOs.ProductAttributeTemplate;
using Compare.BLL.DTOs.ProductOption;
using Compare.DAL.Data;
using Compare.DAL.Models.Attribute;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pat = Compare.DAL.Models.Attribute;

namespace Compare.BLL.Services.ProductAttributeTemplate
{
    public class ProductAttributeTemplateService : IProductAttributeTemplateService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductAttributeTemplateService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateProductAttributeTemplateAsync(CreateProductAttributeTemplateDTO modelDTO)
        {
            List<ProductAttributeTemplateAndProductOption> productAttributeTemplateAndProductOptions = new List<ProductAttributeTemplateAndProductOption>();

            pat.ProductAttributeTemplate prdAT = _mapper.Map<pat.ProductAttributeTemplate>(modelDTO);
            foreach (int catId in modelDTO.ProductOptionId)
            {
                productAttributeTemplateAndProductOptions.Add(new ProductAttributeTemplateAndProductOption()
                {
                    ProductAttributeTemplateId = prdAT.Id,
                    ProductOptionId = catId
                });
            }
            prdAT.ProductAttributeTemplateAndProductOptions = productAttributeTemplateAndProductOptions;

            await _dbContext.ProductAttributeTemplates.AddAsync(prdAT);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditProductAttributeTemplateAsync(EditProductAttributeTemplateDTO modelDTO)
        {
            var prdAT = await _dbContext.ProductAttributeTemplates.Include(p => p.ProductAttributeTemplateAndProductOptions).AsSplitQuery()
                .Include(p => p.ProductAttributeTemplateTranslates).AsSplitQuery()
                .SingleOrDefaultAsync(p => p.Id == modelDTO.Id);

            prdAT.ProductAttributeTemplateTranslates.Clear();
            prdAT.ProductAttributeTemplateAndProductOptions.Clear();

            prdAT.ProductAttributeTemplateTranslates = modelDTO.ProductAttributeTemplateTranslates
                .Select(p => new ProductAttributeTemplateTranslate
                {
                    LanguageCulture = p.LanguageCulture,
                    ProductAttributeTemplateId = p.ProductAttributeTemplateId,
                    Name = p.Name
                }).ToList();

            prdAT.ProductAttributeTemplateAndProductOptions = modelDTO.ProductOptionId
                .Select(p => new ProductAttributeTemplateAndProductOption
                {
                    ProductAttributeTemplateId = prdAT.Id,
                    ProductOptionId = p
                }).ToList();

            _dbContext.ProductAttributeTemplates.Update(prdAT);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<ProductAttributeTemplateListDTO> GetAllProductAttributeTemplates()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var prdAT = _dbContext.ProductAttributeTemplates.AsQueryable();
            var result = _dbContext.ProductAttributeTemplateTranslates
                .Where(p => p.LanguageCulture == culture).Join(prdAT, p => p.ProductAttributeTemplateId, k => k.Id,
                (p, k) => new ProductAttributeTemplateListDTO
                {
                    Id = k.Id,
                    Name = p.Name
                });
            return result;
        }

        public async Task<EditProductAttributeTemplateDTO> GetEditProductAttributeTemplateAsync(int id)
        {
            pat.ProductAttributeTemplate prdAT = await _dbContext.ProductAttributeTemplates
                .Include(i => i.ProductAttributeTemplateTranslates).AsSplitQuery()
                .Include(i => i.ProductAttributeTemplateAndProductOptions).AsSplitQuery()
                .SingleOrDefaultAsync(s => s.Id == id);
            EditProductAttributeTemplateDTO editProductAttributeTemplateDTO = _mapper.Map<EditProductAttributeTemplateDTO>(prdAT);
            return editProductAttributeTemplateDTO;
        }

        public IEnumerable<ProductOptionCultureDTO> GetProductOptionsCultureListId(int id)
        {
            List<ProductOptionCultureDTO> productOptionCultureDTOs = new List<ProductOptionCultureDTO>();
            var pat = _dbContext.ProductAttributeTemplateAndProductOptions.Where(p => p.ProductAttributeTemplateId == id)
                .Include(i => i.ProductOption)
                .ThenInclude(t => t.ProductOptionTranslates).AsSplitQuery().AsQueryable();

            foreach (var pAT in pat)
            {
                foreach (var translate in pAT.ProductOption.ProductOptionTranslates)
                {
                    productOptionCultureDTOs.Add(new ProductOptionCultureDTO()
                    {
                        Name = translate.Name,
                        LanguageCulture = translate.LanguageCulture
                    });
                }
            }

            return productOptionCultureDTOs;
        }

        public async Task RemoveProductAttributeTemplateAsync(int id)
        {
            var prdAT = await _dbContext.ProductAttributeTemplates.FindAsync(id);
            _dbContext.ProductAttributeTemplates.Remove(prdAT);
            await _dbContext.SaveChangesAsync();
        }
    }
}
