using AutoMapper;
using Compare.BLL.DTOs.Commentary.ProductCommentary;
using Compare.DAL.Data;
using Compare.DAL.Models.Commentary;
using Compare.DAL.Models.User;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.ProductCommentary
{
    public class ProductCommentService : IProductCommentService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductCommentService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateProductCommentAsync(ProductCommentCreateDto modelDTO)
        {
            var productComment = _mapper.Map<ProductComment>(modelDTO);
            productComment.PublicateDate = DateTime.Now;
            productComment.IsPublish = false;
            await _dbContext.ProductComments.AddAsync(productComment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditProductCommentAsync(ProductCommentEditDto modelDTO)
        {
            var productComment = _mapper.Map<ProductComment>(modelDTO);
            _dbContext.ProductComments.Update(productComment);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<ProductCommentListDto> GetAllProductComments()
        {
            var productComments = _dbContext.ProductComments.AsQueryable();
            var productCommentDtos = _mapper.Map<IEnumerable<ProductComment>, IEnumerable<ProductCommentListDto>>(productComments);

            return productCommentDtos.OrderByDescending(o => o.Id);
        }

        public IEnumerable<ProductCommentListDto> GetAllProductCommentsByUser(string userId)
        {
            var productComments = _dbContext.ProductComments.Where(p => p.ApplicationUserId == userId).AsQueryable();
            var productCommentDtos = _mapper.Map<IEnumerable<ProductComment>, IEnumerable<ProductCommentListDto>>(productComments);

            return productCommentDtos.OrderByDescending(o => o.Id);
        }

        public async Task<ProductCommentEditDto> GetProductCommentAsync(int id)
        {
            var find = await _dbContext.ProductComments.FindAsync(id);
            ProductCommentEditDto productCommentEditDto = _mapper.Map<ProductCommentEditDto>(find);

            return productCommentEditDto;
        }

        public async Task RemoveProductCommentAsync(int id)
        {
            var find = await _dbContext.ProductComments.FindAsync(id);
            _dbContext.ProductComments.Remove(find);
            await _dbContext.SaveChangesAsync();
        }
    }
}
