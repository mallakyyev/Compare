using AutoMapper;
using Compare.BLL.DTOs.Advertising;
using Compare.DAL.Data;
using Compare.DAL.Models.Advertising;
using Compare.DAL.Models.Enums;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Advertising
{
    public class AdvertService : IAdvertService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _appEnvironment;

        public AdvertService(ApplicationDbContext dbContext, IMapper mapper, IHostingEnvironment appEnvironment)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _appEnvironment = appEnvironment;
        }

        public async Task CreateAdvertAsync(CreateAdvertDTO modelDTO)
        {
            var advert = _mapper.Map<Advert>(modelDTO);
            if (modelDTO.FormFile != null)
            {
                string fileName = await ImageService.UploadImage(modelDTO.FormFile, "/images/adverts/", _appEnvironment);
                advert.Image = fileName;
            }
            await _dbContext.Adverts.AddAsync(advert);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditAdvertAsync(EditAdvertDTO modelDTO)
        {
            var advert = _mapper.Map<Advert>(modelDTO);
            if (modelDTO.FormFile != null)
            {
                if (modelDTO.Image != null)
                {
                    ImageService.DeleteImage(modelDTO.Image, "/images/adverts/", _appEnvironment);
                }
                string fileName = await ImageService.UploadImage(modelDTO.FormFile, "/images/adverts/", _appEnvironment);
                advert.Image = fileName;
            }

            _dbContext.Adverts.Update(advert);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<AdvertListDTO> GetAllAdverts()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var adverts = _dbContext.Adverts.AsQueryable();
            var result = _dbContext.AdvertTranslates
                .Where(p => p.LanguageCulture == culture).Join(adverts, p => p.AdvertId, k => k.Id,
                (p, k) => new AdvertListDTO
                {
                    Id = k.Id,
                    Name = p.Name,
                    Image = k.Image,
                    AdvertPlaceStatus = k.AdvertPlaceStatus,
                    PagePlaceStatus = k.PagePlaceStatus,
                    DateStart = k.DateStart,
                    DateEnd = k.DateEnd,
                    Link = k.Link,
                    DisplayOrder = k.DisplayOrder,
                    IsPublish = k.IsPublish
                });
            return result;
        }

        public async Task<EditAdvertDTO> GetEditAdvertAsync(int id)
        {
            var advert = _mapper.Map<EditAdvertDTO>(await _dbContext.Adverts
                .Include(i => i.AdvertTranslates)
                .SingleOrDefaultAsync(s => s.Id == id));
            return advert;
        }

        public IEnumerable<AdvertListDTO> GetFilterAdverts(PagePlaceStatus pagePlaceStatus, int? categoryId)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var adverts = _dbContext.Adverts.Where(p => (p.PagePlaceStatus == pagePlaceStatus && p.CategoryId == categoryId
            || p.PagePlaceStatus == pagePlaceStatus) && p.DateStart <= DateTime.Now.Date && p.DateEnd >= DateTime.Now.Date);
            var result = _dbContext.AdvertTranslates
                .Where(p => p.LanguageCulture == culture).Join(adverts, p => p.AdvertId, k => k.Id,
                (p, k) => new AdvertListDTO
                {
                    Id = k.Id,
                    Name = p.Name,
                    Image = k.Image,
                    AdvertPlaceStatus = k.AdvertPlaceStatus,
                    PagePlaceStatus = k.PagePlaceStatus,
                    DateStart = k.DateStart,
                    DateEnd = k.DateEnd,
                    Link = k.Link,
                    DisplayOrder = k.DisplayOrder,
                    IsPublish = k.IsPublish
                });
            return result;
        }

        public async Task RemoveAdvertAsync(int id)
        {
            var advert = await _dbContext.Adverts.FindAsync(id);
            if (advert.Image != null)
            {
                ImageService.DeleteImage(advert.Image, "/images/adverts/", _appEnvironment);
            }
            _dbContext.Adverts.Remove(advert);
            await _dbContext.SaveChangesAsync();
        }
    }
}
