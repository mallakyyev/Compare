using Compare.DAL.Models.Advertising;
using Compare.DAL.Models.Attribute;
using Compare.DAL.Models.Bookmarks;
using Compare.DAL.Models.Cart;
using Compare.DAL.Models.Catalog;
using Compare.DAL.Models.Commentary;
using Compare.DAL.Models.Company;
using Compare.DAL.Models.Configuration;
using Compare.DAL.Models.Home;
using Compare.DAL.Models.Info;
using Compare.DAL.Models.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryAndProduct> CategoriesAndProducts { get; set; }
        public DbSet<CategoryTranslate> CategoryTranslates { get; set; }
        public DbSet<Manufacture> Manufactures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTranslate> ProductTranslates { get; set; }
        public DbSet<ProductMedia> ProductMedias { get; set; }
        public DbSet<ProductDetailAttribute> ProductDetailAttributes { get; set; }
        public DbSet<ProductDetailAttributeTranslate> ProductDetailAttributeTranslates { get; set; }
        public DbSet<CategoryPanel> CategoryPanels { get; set; }
        public DbSet<CategoryPanelTranslate> CategoryPanelTranslates { get; set; }
        public DbSet<CategoryPanelAndProduct> CategoryPanelAndProducts { get; set; }

        public DbSet<ProductOption> ProductOptions { get; set; }
        public DbSet<ProductOptionTranslate> ProductOptionTranslates { get; set; }
        public DbSet<ProductAttributeTemplate> ProductAttributeTemplates { get; set; }
        public DbSet<ProductAttributeTemplateTranslate> ProductAttributeTemplateTranslates { get; set; }
        public DbSet<ProductAttributeTemplateAndProductOption> ProductAttributeTemplateAndProductOptions { get; set; }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationApi> OrganizationApis { get; set; }
        public DbSet<CategoryAndOrganizationApi> CategoriesAndOrganizationApis { get; set; }
        public DbSet<OrganizationProduct> OrganizationProducts { get; set; }
        public DbSet<OrganizationSubscription> OrganizationSubscriptions { get; set; }

        public DbSet<Banner> Banners { get; set; }
        public DbSet<BannerTranslate> BannerTranslates { get; set; }
        public DbSet<Panel> Panels { get; set; }
        public DbSet<PanelTranslate> PanelTranslates { get; set; }
        public DbSet<PanelAndProduct> PanelAndProducts { get; set; }

        public DbSet<Information> Informations { get; set; }
        public DbSet<InformationTranslate> InformationTranslates { get; set; }

        public DbSet<Advert> Adverts { get; set; }
        public DbSet<AdvertTranslate> AdvertTranslates { get; set; }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<StoreComment> StoreComments { get; set; }

        public DbSet<Bookmark> Bookmarks { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderOrganization> OrderOrganizations { get; set; }
        public DbSet<Basket> Baskets { get; set; }

        public DbSet<Language> Languages { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Применение всех конфигурация в сборке
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            base.OnModelCreating(builder);
        }
    }
}
