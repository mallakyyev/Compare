using AutoMapper;
using Compare.BLL.DTOs.ProductOption;
using Compare.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prdOpt = Compare.DAL.Models.Attribute;

namespace Compare.BLL.Services.ProductOption
{
    public class ProductOptionService : IProductOptionService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductOptionService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateProductOptionAsync(CreateProductOptionDTO modelDTO)
        {
            var productOption = _mapper.Map<prdOpt.ProductOption>(modelDTO);
            await _dbContext.ProductOptions.AddAsync(productOption);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditProductOptionAsync(EditProductOptionDTO modelDTO)
        {
            var productOption = _mapper.Map<prdOpt.ProductOption>(modelDTO);
            _dbContext.ProductOptions.Update(productOption);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<ProductOptionListDTO> GetAllproductOption()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var productOption = _dbContext.ProductOptions.AsQueryable();
            var result = _dbContext.ProductOptionTranslates
                .Where(p => p.LanguageCulture == culture).Join(productOption, p => p.ProductOptionId, t => t.Id,
                (p, t) => new ProductOptionListDTO
                {
                    Id = t.Id,
                    Name = p.Name
                });
            return result;
        }

        public async Task<EditProductOptionDTO> GetEditProductOptionAsync(int id)
        {
            var editProductOptionDTO = _mapper.Map<EditProductOptionDTO>(await _dbContext.ProductOptions
                .Include(i => i.ProductOptionTranslates)
                .SingleOrDefaultAsync(s => s.Id == id));
            return editProductOptionDTO;
        }

        public async Task RemoveProductOptionAsync(int id)
        {
            var productOption = await _dbContext.ProductOptions.FindAsync(id);
            _dbContext.ProductOptions.Remove(productOption);
            await _dbContext.SaveChangesAsync();
        }
    }
}
