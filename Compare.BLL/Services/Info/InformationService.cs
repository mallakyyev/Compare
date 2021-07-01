using AutoMapper;
using Compare.BLL.DTOs.Info;
using Compare.DAL.Data;
using Compare.DAL.Models.Enums;
using Compare.DAL.Models.Info;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Info
{
    public class InformationService : IInformationService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public InformationService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateInformationAsync(CreateInformationDTO modelDTO)
        {
            var info = _mapper.Map<Information>(modelDTO);
            await _dbContext.AddAsync(info);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditInformationAsync(EditInformationDTO modelDTO)
        {
            var info = _mapper.Map<Information>(modelDTO);
            _dbContext.Informations.Update(info);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<EditInformationDTO> GetEditInformationAsync(InformationStatus informationStatus)
        {
            var info = await _dbContext.Informations
                .Include(i => i.InformationTranslates).AsSplitQuery()
                .SingleOrDefaultAsync(s => s.InformationStatus == informationStatus);
            var infoDto = _mapper.Map<EditInformationDTO>(info);
            return infoDto;
        }

        public async Task<InformationListDTO> GetInformationListAsync(InformationStatus informationStatus)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var info = await _dbContext.Informations
                .Include(i => i.InformationTranslates).AsSplitQuery()
                .SingleOrDefaultAsync(s => s.InformationStatus == informationStatus);
            var infoDto = new InformationListDTO();

            if (info != null)
            {
                infoDto.Id = info.Id;
                infoDto.InformationStatus = info.InformationStatus;
                infoDto.Description = info.InformationTranslates.SingleOrDefault(s => s.LanguageCulture == culture).Description;
                infoDto.Address = info.InformationTranslates.SingleOrDefault(s => s.LanguageCulture == culture).Address;
                infoDto.Phone = info.Phone;
                infoDto.Email = info.Email;

                return infoDto;
            }
            return null;
        }
    }
}
