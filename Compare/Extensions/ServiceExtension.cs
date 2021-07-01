using Compare.BLL.Services.Advertising;
using Compare.BLL.Services.Banner;
using Compare.BLL.Services.Bookmarks;
using Compare.BLL.Services.Cart.Basket;
using Compare.BLL.Services.Catalog;
using Compare.BLL.Services.CatalogPanel;
using Compare.BLL.Services.Checking;
using Compare.BLL.Services.GoogleReCaptcha;
using Compare.BLL.Services.Info;
using Compare.BLL.Services.Language;
using Compare.BLL.Services.Manufacture;
using Compare.BLL.Services.Organization;
using Compare.BLL.Services.OrganizationSubscription;
using Compare.BLL.Services.Panel;
using Compare.BLL.Services.Parser;
using Compare.BLL.Services.Product;
using Compare.BLL.Services.ProductAttributeTemplate;
using Compare.BLL.Services.ProductCommentary;
using Compare.BLL.Services.ProductDetailAttribute;
using Compare.BLL.Services.ProductOption;
using Compare.BLL.Services.StoreCommentary;
using Compare.BLL.Services.User;
using Microsoft.Extensions.DependencyInjection;

namespace Compare.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IParser, Parser>();
            services.AddTransient<GoogleReCaptchaService>();

            services.AddTransient<IManufactureService, ManufactureService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ILanguageService, LanguageService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrganizationService, OrganizationService>();
            services.AddTransient<IOrganizationSubscriptionService, OrganizationSubscriptionService>();
            services.AddTransient<IPanelService, PanelService>();
            services.AddTransient<IBannerService, BannerService>();
            services.AddTransient<IInformationService, InformationService>();
            services.AddTransient<IProductOptionService, ProductOptionService>();
            services.AddTransient<IProductAttributeTemplateService, ProductAttributeTemplateService>();
            services.AddTransient<IProductDetailAttributeService, ProductDetailAttributeService>();
            services.AddTransient<IAdvertService, AdvertService>();
            services.AddTransient<IApplicationUserService, ApplicationUserService>();
            services.AddTransient<ICategoryPanelService, CategoryPanelService>();
            services.AddTransient<ICheckingService, CheckingService>();
            services.AddTransient<IProductCommentService, ProductCommentService>();
            services.AddTransient<IStoreCommentService, StoreCommentService>();
            services.AddTransient<IBookmarkService, BookmarkService>();
            services.AddTransient<IBasketService, BasketService>();

            return services;
        }
    }
}
