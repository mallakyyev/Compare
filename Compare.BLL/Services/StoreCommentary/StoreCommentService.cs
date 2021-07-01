using AutoMapper;
using Compare.BLL.DTOs.Commentary.StoreCommentary;
using Compare.DAL.Data;
using Compare.DAL.Models.Commentary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.StoreCommentary
{
    public class StoreCommentService : IStoreCommentService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public StoreCommentService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateStoreCommentAsync(StoreCommentCreateDto modelDTO)
        {
            var storeComment = _mapper.Map<StoreComment>(modelDTO);
            storeComment.PublicateDate = DateTime.Now;
            storeComment.IsPublish = false;
            await _dbContext.StoreComments.AddAsync(storeComment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditStoreCommentAsync(StoreCommentEditDto modelDTO)
        {
            var storeComment = _mapper.Map<StoreComment>(modelDTO);
            _dbContext.StoreComments.Update(storeComment);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<StoreCommentListDto> GetAllStoreComments()
        {
            var storeComments = _dbContext.StoreComments.AsQueryable();
            var storeCommentDtos = _mapper.Map<IEnumerable<StoreComment>, IEnumerable<StoreCommentListDto>>(storeComments);

            return storeCommentDtos.OrderByDescending(o => o.Id);
        }

        public IEnumerable<StoreCommentListDto> GetAllStoreCommentsByUser(string userId)
        {
            var storeComments = _dbContext.StoreComments.Where(p => p.ApplicationUserId == userId).AsQueryable();
            var storeCommentDtos = _mapper.Map<IEnumerable<StoreComment>, IEnumerable<StoreCommentListDto>>(storeComments);

            return storeCommentDtos.OrderByDescending(o => o.Id);
        }

        public async Task<StoreCommentEditDto> GetStoreCommentAsync(int id)
        {
            var find = await _dbContext.StoreComments.FindAsync(id);
            StoreCommentEditDto storeCommentEditDto = _mapper.Map<StoreCommentEditDto>(find);

            return storeCommentEditDto;
        }

        public async Task RemoveStoreCommentAsync(int id)
        {
            var find = await _dbContext.StoreComments.FindAsync(id);
            _dbContext.StoreComments.Remove(find);
            await _dbContext.SaveChangesAsync();
        }
    }
}
