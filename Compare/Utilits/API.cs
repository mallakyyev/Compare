using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Utilits
{
    public static class API
    {
        public static string GeAllManufacturiesAPI { get; } = "/api/ManufactureAPI";
        public static string CRUDManufactureAPI { get; } = "/api/ManufactureAPI";

        public static string GetAllCategories { get; } = "/api/CategoryAPI";
        public static string GetAllPublishCategoryParent { get; } = "/api/CategoryAPI/GetAllPublishCategoryParent";
        public static string GetAllPublishCategories { get; } = "/api/CategoryAPI/GetAllPublishCategory";
        public static string CRUDCategories { get; } = "/api/CategoryAPI";

        public static string GetAllProducts { get; } = "/api/ProductAPI";
        public static string CRUDProduct { get; } = "/api/ProductAPI";
        public static string GetProductCategoryParentList { get; } = "/api/ProductAPI/GetProductCategoryParentList";
        public static string GetAllProductsOrganizationSubscription { get; } = "/api/ProductAPI/GetAllProductsOrganizationSubscription";

        public static string GetProductMedias { get; } = "/api/ProductAPI/GetProductMediasId";
        public static string RemoveProductMedia { get; } = "/api/ProductAPI/RemoveMediaId";

        public static string GetAllOrganizations { get; } = "/api/OrganizationAPI";
        public static string CRUDOrganization { get; } = "/api/OrganizationAPI";

        public static string GetAllOrganizationsApi { get; } = "/api/OrganizationAPI/GetOrganizationApi";
        public static string RemoveOrganizationApi { get; } = "/api/OrganizationAPI/DeleteOrganizationApi";

        public static string GetAllOrganizationProducts { get; } = "/api/OrganizationAPI/GetOrganizationProductsApi";
        public static string RemoveOrganizationProduct { get; } = "/api/OrganizationAPI/DeleteOrganizationProductApi";
        public static string GetStoreProductsApi { get; } = "/api/OrganizationAPI/GetStoreProductsApi";

        public static string GetAllOrganizationSubscriptions { get; } = "/api/OrganizationSubscriptionAPI";
        public static string RemoveOrganizationSubscription { get; } = "/api/OrganizationSubscriptionAPI";
        public static string GetOrganizationSubscriptionsById { get; } = "/api/OrganizationSubscriptionAPI/OrganizationSubscriptionsById";

        public static string GetAllPanels { get; } = "/api/PanelAPI";
        public static string RemovePanel { get; } = "/api/PanelAPI";

        public static string GetAllBanners { get; } = "/api/BannerAPI";
        public static string RemoveBanner { get; } = "/api/BannerAPI";

        public static string GetAllProductOptions { get; } = "/api/ProductOptionAPI";
        public static string RemoveProductOption { get; } = "/api/ProductOptionAPI";

        public static string GetAllProductAttributeTemplates { get; } = "/api/ProductAttributeTemplateAPI";
        public static string RemoveProductAttributeTemplate { get; } = "/api/ProductAttributeTemplateAPI";

        public static string GetAllAdverts { get; } = "/api/AdvertAPI";
        public static string RemoveAdvert { get; } = "/api/AdvertAPI";

        public static string GetAllUsers { get; } = "/api/ApplicationUserAPI";
        public static string RemoveUser { get; } = "/api/ApplicationUserAPI";

        public static string GetAllPublishCategoryPanels { get; } = "/api/CategoryPanelAPI";
        public static string RemoveCategoryPanel { get; } = "/api/CategoryPanelAPI";

        public static string ProductCommentApi { get; } = "/api/ProductCommentApi";
        public static string GetAllProductCommentsByUser { get; } = "/api/ProductCommentApi/GetAllProductCommentsByUser";
        public static string StoreCommentApi { get; } = "/api/StoreCommentApi";
        public static string GetAllStoreCommentsByUser { get; } = "/api/StoreCommentApi/GetAllStoreCommentsByUser";

        public static string BasketAPI { get; } = "/api/BasketAPI";
        public static string GetAllBasketProductsByApplicationUserId { get; } = "/api/BasketAPI/GetAllBasketProductsByApplicationUserId";
    }
}
