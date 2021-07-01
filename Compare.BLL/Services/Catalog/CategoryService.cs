using AutoMapper;
using Compare.BLL.DTOs.Catalog;
using Compare.DAL.Data;
using Compare.DAL.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Catalog
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CategoryService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateCategoryAsync(CreateCategoryDTO modelDTO)
        {
            Category category = _mapper.Map<Category>(modelDTO);
            await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditCategoryAsync(EditCategoryDTO modelDTO)
        {
            Category category = _mapper.Map<Category>(modelDTO);
            _dbContext.Categories.Update(category);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<CategoryDTO> GetAllCategory()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var categories = _dbContext.Categories.AsQueryable();
            var result = _dbContext.CategoryTranslates
                .Where(p => p.LanguageCulture == culture).Join(categories, p => p.CategoryId, k => k.Id,
                (p, k) => new CategoryDTO
                {
                    Id = k.Id,
                    Name = p.Name,
                    MetaTitle = p.MetaTitle,
                    MetaDescription = p.MetaDescription,
                    DisplayOrder = k.DisplayOrder,
                    ParentCategoryId = k.ParentCategoryId,
                    Published = k.Published
                });
            return result;
        }

        public IEnumerable<CategoryDTO> GetAllPublishCategory()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var categories = _dbContext.Categories.Where(p => p.Published == true).AsQueryable();
            var result = _dbContext.CategoryTranslates
                .Where(p => p.LanguageCulture == culture).Join(categories, p => p.CategoryId, k => k.Id,
                (p, k) => new CategoryDTO
                {
                    Id = k.Id,
                    Name = p.Name,
                    MetaTitle = p.MetaTitle,
                    MetaDescription = p.MetaDescription,
                    DisplayOrder = k.DisplayOrder,
                    ParentCategoryId = k.ParentCategoryId,
                    Published = k.Published
                });
            return result;
        }

        public IEnumerable<CategoryDTO> GetAllPublishCategoryParent()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var categories = _dbContext.Categories.Where(p => p.Published == true && p.ParentCategoryId == null).AsQueryable();
            var result = _dbContext.CategoryTranslates
                .Where(p => p.LanguageCulture == culture).Join(categories, p => p.CategoryId, k => k.Id,
                (p, k) => new CategoryDTO
                {
                    Id = k.Id,
                    Name = p.Name,
                    MetaTitle = p.MetaTitle,
                    MetaDescription = p.MetaDescription,
                    DisplayOrder = k.DisplayOrder,
                    ParentCategoryId = k.ParentCategoryId,
                    Published = k.Published
                });
            return result;
        }

        public IEnumerable<CategoryDTO> GetAllPublishCategoryByParentId(int parentId)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var categories = _dbContext.Categories
                .Include(i => i.CategoryTranslates).AsSplitQuery()
                .Include(i => i.Categories).ThenInclude(t => t.CategoryTranslates).AsSplitQuery()
                .Include(i => i.Categories).ThenInclude(t => t.Categories).ThenInclude(t => t.CategoryTranslates).AsSplitQuery()
                .Where(p => p.Published == true && p.Id == parentId);
            //var result = _dbContext.CategoryTranslates
            //    .Where(p => p.LanguageCulture == culture).Join(categories, p => p.CategoryId, k => k.Id,
            //    (p, k) => new CategoryDTO
            //    {
            //        Id = k.Id,
            //        Name = p.Name,
            //        MetaTitle = p.MetaTitle,
            //        MetaDescription = p.MetaDescription,
            //        DisplayOrder = k.DisplayOrder,
            //        ParentCategoryId = k.ParentCategoryId,
            //        Published = k.Published,
            //        Categories = new CategoryDTO
            //        {
            //            Id = k.Categories
            //        }
            //    });
            var result = new List<CategoryDTO>();
            foreach (var category in categories)
            {
                var categoryDTO = new CategoryDTO();
                categoryDTO.Id = category.Id;
                categoryDTO.Name = category.CategoryTranslates.SingleOrDefault(s => s.LanguageCulture == culture).Name;
                categoryDTO.MetaTitle = category.CategoryTranslates.SingleOrDefault(s => s.LanguageCulture == culture).MetaTitle;
                categoryDTO.MetaDescription = category.CategoryTranslates.SingleOrDefault(s => s.LanguageCulture == culture).MetaDescription;
                categoryDTO.DisplayOrder = category.DisplayOrder;
                categoryDTO.ParentCategoryId = category.ParentCategoryId;
                categoryDTO.Published = category.Published;
                categoryDTO.Categories = new List<CategoryDTO>();
                foreach (var cat in category.Categories)
                {
                    var catDTO = new CategoryDTO();
                    catDTO.Id = cat.Id;
                    catDTO.Name = cat.CategoryTranslates.SingleOrDefault(s => s.LanguageCulture == culture).Name;
                    catDTO.MetaTitle = cat.CategoryTranslates.SingleOrDefault(s => s.LanguageCulture == culture).MetaTitle;
                    catDTO.MetaDescription = cat.CategoryTranslates.SingleOrDefault(s => s.LanguageCulture == culture).MetaDescription;
                    catDTO.DisplayOrder = cat.DisplayOrder;
                    catDTO.ParentCategoryId = cat.ParentCategoryId;
                    catDTO.Published = cat.Published;
                    catDTO.Categories = new List<CategoryDTO>();
                    foreach (var child in cat.Categories)
                    {
                        catDTO.Categories.Add(new CategoryDTO
                        {
                            Id = child.Id,
                            Name = child.CategoryTranslates.SingleOrDefault(s => s.LanguageCulture == culture).Name,
                            MetaTitle = child.CategoryTranslates.SingleOrDefault(s => s.LanguageCulture == culture).MetaTitle,
                            MetaDescription = child.CategoryTranslates.SingleOrDefault(s => s.LanguageCulture == culture).MetaDescription,
                            DisplayOrder = child.DisplayOrder,
                            ParentCategoryId = child.ParentCategoryId,
                            Published = child.Published
                        });
                    }
                    categoryDTO.Categories.Add(catDTO);
                }

                result.Add(categoryDTO);
            }
            return result;
        }

        public async Task<CategoryDTO> GetCategoryDTOAsync(int id)
        {
            CategoryDTO categoryDTO = new CategoryDTO();
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var category = await _dbContext.Categories.Include(i => i.CategoryTranslates)
                .SingleOrDefaultAsync(s => s.Id == id);
            if (category != null)
            {
                categoryDTO.Id = category.Id;
                categoryDTO.Name = category.CategoryTranslates.SingleOrDefault(s => s.LanguageCulture == culture).Name;
                categoryDTO.MetaTitle = category.CategoryTranslates.SingleOrDefault(s => s.LanguageCulture == culture).MetaTitle;
                categoryDTO.MetaDescription = category.CategoryTranslates.SingleOrDefault(s => s.LanguageCulture == culture).MetaDescription;
                categoryDTO.ParentCategoryId = category.ParentCategoryId;
                categoryDTO.Published = category.Published;
            }

            return categoryDTO;
        }

        public async Task<EditCategoryDTO> GetCategoryAsync(int id)
        {
            Category category = await _dbContext.Categories.Include(i => i.CategoryTranslates)
                .SingleOrDefaultAsync(s => s.Id == id);
            EditCategoryDTO categoryDTO = _mapper.Map<EditCategoryDTO>(category);
            return categoryDTO;
        }

        public async Task RemoveCategoryAsync(int id)
        {
            Category category = await _dbContext.Categories.FindAsync(id);
            _dbContext.Categories.Remove(category);
            await _dbContext.SaveChangesAsync();
        }
    }
}
