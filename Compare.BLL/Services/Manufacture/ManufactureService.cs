using AutoMapper;
using Compare.BLL.DTOs.Manufacture;
using Compare.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using manufacture = Compare.DAL.Models.Catalog;

namespace Compare.BLL.Services.Manufacture
{
    public class ManufactureService : IManufactureService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IServiceProvider _serviceProvider;

        public ManufactureService(ApplicationDbContext dbContext, IMapper mapper, IServiceProvider serviceProvider)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _serviceProvider = serviceProvider;
        }

        public async Task CreateManufacture(CreateManufactureDTO modelDTO)
        {
            manufacture.Manufacture mnf = _mapper.Map<manufacture.Manufacture>(modelDTO);
            await _dbContext.Manufactures.AddAsync(mnf);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditManufacture(ManufactureDTO modelDTO)
        {
            manufacture.Manufacture mnf = _mapper.Map<manufacture.Manufacture>(modelDTO);
            _dbContext.Manufactures.Update(mnf);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<ManufactureDTO> GetAllManufacture()
        {
            var manufactureDTOs = _mapper.Map<IEnumerable<manufacture.Manufacture>, IEnumerable<ManufactureDTO>>(GetList().AsQueryable());
            return manufactureDTOs;
        }

        public IEnumerable<manufacture.Manufacture> GetList()
        {
            var manufactures = _dbContext.Manufactures.ToList();
            return manufactures;
        }

        public async Task<IEnumerable<ManufactureDTO>> GetManufactureProductsAsync(IEnumerable<int> manufactureId)
        {
            List<ManufactureDTO> manufactureDTO = new List<ManufactureDTO>();
            try
            {
                using(var scope = _serviceProvider.CreateScope())
                {
                    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    foreach (var id in manufactureId)
                    {
                        var manufacture = await db.Manufactures.SingleOrDefaultAsync(s => s.Id == id);
                        if (manufacture != null)
                        {
                            manufactureDTO.Add(new ManufactureDTO()
                            {
                                Id = manufacture.Id,
                                Name = manufacture.Name,
                                Image = manufacture.Image,
                                DisplayOrder = manufacture.DisplayOrder
                            });
                        }
                    }
                }
                
            }
            catch(Exception ex)
            {
                throw;
            }

            return manufactureDTO.OrderBy(o => o.Name);
        }

        public async Task RemoveManufacture(int id)
        {
            manufacture.Manufacture mnf = await _dbContext.Manufactures.FindAsync(id);
            _dbContext.Manufactures.Remove(mnf);
            await _dbContext.SaveChangesAsync();
        }
    }
}
