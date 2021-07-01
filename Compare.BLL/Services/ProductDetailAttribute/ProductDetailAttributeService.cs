using AutoMapper;
using Compare.BLL.DTOs.ProductDetailAttribute;
using Compare.BLL.Services.Product;
using Compare.DAL.Data;
using Compare.DAL.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pda = Compare.DAL.Models.Catalog;

namespace Compare.BLL.Services.ProductDetailAttribute
{
    public class ProductDetailAttributeService : IProductDetailAttributeService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductDetailAttributeService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateProductDetailAttributeAsync(CreateProductDetailAttributeDTO modelDTO)
        {
            var pDA = _mapper.Map<pda.ProductDetailAttribute>(modelDTO);
            await _dbContext.ProductDetailAttributes.AddAsync(pDA);
            await _dbContext.SaveChangesAsync();

            await UpdateFieldProductDetailAttributeId(pDA.ProductId, pDA.Id);
        }

        public async Task EditProductDetailAttributeAsync(EditProductDetailAttributeDTO modelDTO)
        {
            var productDetailAttribute = await _dbContext.ProductDetailAttributes
                .Include(p => p.ProductDetailAttributeTranslates).AsSplitQuery()
                .SingleOrDefaultAsync(p => p.Id == modelDTO.Id);

            productDetailAttribute.ProductDetailAttributeTranslates.Clear();

            productDetailAttribute.ProductDetailAttributeTranslates = modelDTO.ProductDetailAttributeTranslates
                .Select(p => new ProductDetailAttributeTranslate
                {
                    Name = p.Name,
                    Value = p.Value,
                    LanguageCulture = p.LanguageCulture
                }).ToList();

            productDetailAttribute.ProductId = modelDTO.ProductId;

            _dbContext.ProductDetailAttributes.Update(productDetailAttribute);
            await _dbContext.SaveChangesAsync();
        }

        public async Task FindProductDetailAttributeAndCreateCopyAsync(int productId, int newProductId)
        {
            var product = await _dbContext.ProductDetailAttributes
                .Include(i => i.ProductDetailAttributeTranslates).AsSplitQuery()
                .SingleOrDefaultAsync(s => s.ProductId == productId);

            if(product != null)
            {
                var createProductDetailAttributeDTO = new CreateProductDetailAttributeDTO();
                createProductDetailAttributeDTO.ProductId = newProductId;
                createProductDetailAttributeDTO.ProductDetailAttributeTranslates = new List<ProductDetailAttributeTranslateDTO>();
                foreach(var productDetailAttributeTranslate in product.ProductDetailAttributeTranslates)
                {
                    createProductDetailAttributeDTO.ProductDetailAttributeTranslates.Add(new ProductDetailAttributeTranslateDTO
                    {
                        Name = productDetailAttributeTranslate.Name,
                        Value = productDetailAttributeTranslate.Value,
                        LanguageCulture = productDetailAttributeTranslate.LanguageCulture
                    });
                }
                await CreateProductDetailAttributeAsync(createProductDetailAttributeDTO);
            }
        }

        public async Task<EditProductDetailAttributeDTO> GetEditProductDetailAttributeAsync(int productId)
        {
            var editProductDetailAttributeDTO = _mapper.Map<EditProductDetailAttributeDTO>(await _dbContext.ProductDetailAttributes
                .Include(i => i.ProductDetailAttributeTranslates)
                .SingleOrDefaultAsync(s => s.ProductId == productId));
            return editProductDetailAttributeDTO;
        }

        public async Task UpdateFieldProductDetailAttributeId(int productId, int productDetailAttributeId)
        {
            var product = await _dbContext.Products.FindAsync(productId);
            if (product != null)
            {
                product.ProductDetailAttributeId = productDetailAttributeId;
                _dbContext.Products.Update(product);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
