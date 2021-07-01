using AutoMapper;
using Compare.BLL.DTOs.Configuration;
using Compare.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using language = Compare.DAL.Models.Configuration;

namespace Compare.BLL.Services.Language
{
    public class LanguageService : ILanguageService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public LanguageService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IEnumerable<LanguageDTO> GetAllLanguage()
        {
            var languageDTOs = _mapper.Map<IEnumerable<language.Language>, IEnumerable<LanguageDTO>>(GetList());
            return languageDTOs;
        }

        public IEnumerable<LanguageDTO> GetAllPublishLanguage()
        {
            var languageDTOs = _mapper.Map<IEnumerable<language.Language>, IEnumerable<LanguageDTO>>(GetList().Where(p => p.Published == true));
            return languageDTOs;
        }

        public async Task RemoveLanguageAsync(int id)
        {
            language.Language lng = await _dbContext.Languages.FindAsync(id);
            _dbContext.Languages.Remove(lng);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<language.Language> GetList()
        {
            var languages = _dbContext.Languages.ToList();
            return languages;
        }
    }
}
