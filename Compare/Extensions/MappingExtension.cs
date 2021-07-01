using AutoMapper;
using Compare.BLL.DTOs.Advertising;
using Compare.BLL.DTOs.Banner;
using Compare.BLL.DTOs.Bookmarks;
using Compare.BLL.DTOs.Cart.Basket;
using Compare.BLL.DTOs.Catalog;
using Compare.BLL.DTOs.CatalogPanel;
using Compare.BLL.DTOs.Commentary;
using Compare.BLL.DTOs.Commentary.ProductCommentary;
using Compare.BLL.DTOs.Commentary.StoreCommentary;
using Compare.BLL.DTOs.Configuration;
using Compare.BLL.DTOs.Info;
using Compare.BLL.DTOs.Manufacture;
using Compare.BLL.DTOs.Organization;
using Compare.BLL.DTOs.Panel;
using Compare.BLL.DTOs.Product;
using Compare.BLL.DTOs.ProductAttributeTemplate;
using Compare.BLL.DTOs.ProductDetailAttribute;
using Compare.BLL.DTOs.ProductOption;
using Compare.BLL.DTOs.User;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Extensions
{
    public class MappingExtension : Profile
    {
        public MappingExtension()
        {
            CreateMap<Manufacture, ManufactureDTO>();
            CreateMap<ManufactureDTO, Manufacture>();
            CreateMap<Manufacture, CreateManufactureDTO>();
            CreateMap<CreateManufactureDTO, Manufacture>();

            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();
            CreateMap<Category, CreateCategoryDTO>();
            CreateMap<CreateCategoryDTO, Category>();
            CreateMap<Category, EditCategoryDTO>();
            CreateMap<EditCategoryDTO, Category>();
            CreateMap<CategoryTranslate, CategoryTranslateDTO>();
            CreateMap<CategoryTranslateDTO, CategoryTranslate>();

            CreateMap<CategoryPanel, CategoryPanelDTO>();
            CreateMap<CategoryPanelDTO, CategoryPanel>();
            CreateMap<CategoryPanel, CategoryPanelListDTO>();
            CreateMap<CategoryPanelListDTO, CategoryPanel>();
            CreateMap<CategoryPanel, CreateCategoryPanelDTO>();
            CreateMap<CreateCategoryPanelDTO, CategoryPanel>();
            CreateMap<CategoryPanel, EditCategoryPanelDTO>()
                .ForMember(p => p.ProductsId, from => from.MapFrom(p => p.CategoryPanelAndProducts.Select(s => s.ProductId)));
            CreateMap<EditCategoryPanelDTO, CategoryPanel>();
            CreateMap<CategoryPanelTranslate, CategoryPanelTranslateDTO>();
            CreateMap<CategoryPanelTranslateDTO, CategoryPanelTranslate>();
            CreateMap<CategoryPanelAndProduct, CategoryPanelAndProductDTO>();
            CreateMap<CategoryPanelAndProductDTO, CategoryPanelAndProduct>();

            CreateMap<ProductTranslate, ProductTranslateDTO>();
            CreateMap<ProductTranslateDTO, ProductTranslate>();
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
            CreateMap<Product, CreateProductDTO>();
            CreateMap<CreateProductDTO, Product>();
            CreateMap<Product, EditProductDTO>()
            .ForMember(p => p.CategoriesId, from => from.MapFrom(p => p.CategoriesAndProducts.Select(s => s.CategoryId)));
            CreateMap<EditProductDTO, Product>();
            CreateMap<EditProductDTO, CreateProductDTO>();
            CreateMap<CreateProductDTO, EditProductDTO>();

            CreateMap<ProductMedia, ProductMediaDTO>();
            CreateMap<ProductMediaDTO, ProductMedia>();

            CreateMap<Organization, OrganizationDTO>();
            CreateMap<OrganizationDTO, Organization>();
            CreateMap<Organization, CreateOrganizationDTO>();
            CreateMap<CreateOrganizationDTO, Organization>();
            CreateMap<Organization, EditOrganizationDTO>();
            CreateMap<EditOrganizationDTO, Organization>();

            CreateMap<OrganizationApi, OrganizationApiDTO>();
            CreateMap<OrganizationApiDTO, OrganizationApi>();
            CreateMap<OrganizationApi, CreateOrganizationApiDTO>();
            CreateMap<CreateOrganizationApiDTO, OrganizationApi>();
            CreateMap<OrganizationApi, EditOrganizationApiDTO>()
                .ForMember(p => p.CategoriesId, from => from.MapFrom(p => p.CategoriesAndOrganizationApis.Select(s => s.CategoryId)));
            CreateMap<EditOrganizationApiDTO, OrganizationApi>();

            CreateMap<OrganizationProduct, OrganizationProductDTO>();
            CreateMap<OrganizationProductDTO, OrganizationProduct>();
            CreateMap<OrganizationProduct, OrganizationProductListDTO>();
            CreateMap<OrganizationProductListDTO, OrganizationProduct>();
            CreateMap<OrganizationProduct, CreateOrganizationProductDTO>();
            CreateMap<CreateOrganizationProductDTO, OrganizationProduct>();
            CreateMap<OrganizationProduct, EditOrganizationProductDTO>();
            CreateMap<EditOrganizationProductDTO, OrganizationProduct>();

            CreateMap<OrganizationSubscription, OrganizationSubscriptionDTO>();
            CreateMap<OrganizationSubscriptionDTO, OrganizationSubscription>();
            CreateMap<OrganizationSubscription, OrganizationSubscriptionListDTO>();
            CreateMap<OrganizationSubscriptionListDTO, OrganizationSubscription>();
            CreateMap<OrganizationSubscription, CreateOrganizationSubscriptionDTO>();
            CreateMap<CreateOrganizationSubscriptionDTO, OrganizationSubscription>();
            CreateMap<OrganizationSubscription, EditOrganizationSubscriptionDTO>();
            CreateMap<EditOrganizationSubscriptionDTO, OrganizationSubscription>();

            CreateMap<Banner, BannerDTO>();
            CreateMap<BannerDTO, Banner>();
            CreateMap<Banner, BannerListDTO>();
            CreateMap<BannerListDTO, Banner>();
            CreateMap<Banner, CreateBannerDTO>();
            CreateMap<CreateBannerDTO, Banner>();
            CreateMap<Banner, EditBannerDTO>();
            CreateMap<EditBannerDTO, Banner>();

            CreateMap<BannerTranslate, BannerTranslateDTO>();
            CreateMap<BannerTranslateDTO, BannerTranslate>();

            CreateMap<Panel, PanelDTO>();
            CreateMap<PanelDTO, Panel>();
            CreateMap<Panel, CreatePanelDTO>();
            CreateMap<CreatePanelDTO, Panel>();
            CreateMap<Panel, EditPanelDTO>()
                .ForMember(p => p.ProductsId, from => from.MapFrom(p => p.PanelAndProducts.Select(s => s.ProductId)));
            CreateMap<EditPanelDTO, Panel>();
            CreateMap<Panel, PanelListDTO>();
            CreateMap<PanelListDTO, Panel>();

            CreateMap<PanelTranslate, PanelTranslateDTO>();
            CreateMap<PanelTranslateDTO, PanelTranslate>();

            CreateMap<Information, InformationDTO>();
            CreateMap<InformationDTO, Information>();
            CreateMap<Information, InformationListDTO>();
            CreateMap<InformationListDTO, Information>();
            CreateMap<Information, CreateInformationDTO>();
            CreateMap<CreateInformationDTO, Information>();
            CreateMap<Information, EditInformationDTO>();
            CreateMap<EditInformationDTO, Information>();

            CreateMap<InformationTranslate, InformationTranslateDTO>();
            CreateMap<InformationTranslateDTO, InformationTranslate>();

            CreateMap<ProductOption, ProductOptionDTO>();
            CreateMap<ProductOptionDTO, ProductOption>();
            CreateMap<ProductOption, CreateProductOptionDTO>();
            CreateMap<CreateProductOptionDTO, ProductOption>();
            CreateMap<ProductOption, EditProductOptionDTO>();
            CreateMap<EditProductOptionDTO, ProductOption>();
            CreateMap<ProductOption, ProductOptionListDTO>();
            CreateMap<ProductOptionListDTO, ProductOption>();

            CreateMap<ProductOptionTranslate, ProductOptionTranslateDTO>();
            CreateMap<ProductOptionTranslateDTO, ProductOptionTranslate>();

            CreateMap<ProductAttributeTemplate, ProductAttributeTemplateDTO>();
            CreateMap<ProductAttributeTemplateDTO, ProductAttributeTemplate>();
            CreateMap<ProductAttributeTemplate, ProductAttributeTemplateListDTO>();
            CreateMap<ProductAttributeTemplateListDTO, ProductAttributeTemplate>();
            CreateMap<ProductAttributeTemplate, CreateProductAttributeTemplateDTO>();
            CreateMap<CreateProductAttributeTemplateDTO, ProductAttributeTemplate>();
            CreateMap<ProductAttributeTemplate, EditProductAttributeTemplateDTO>()
            .ForMember(p => p.ProductOptionId, from => from.MapFrom(p => p.ProductAttributeTemplateAndProductOptions.Select(s => s.ProductOptionId)));
            CreateMap<EditProductAttributeTemplateDTO, ProductAttributeTemplate>();

            CreateMap<ProductAttributeTemplateAndProductOption, ProductAttributeTemplateAndProductOptionDTO>();
            CreateMap<ProductAttributeTemplateAndProductOptionDTO, ProductAttributeTemplateAndProductOption>();

            CreateMap<ProductAttributeTemplateTranslate, ProductAttributeTemplateTranslateDTO>();
            CreateMap<ProductAttributeTemplateTranslateDTO, ProductAttributeTemplateTranslate>();

            CreateMap<ProductDetailAttribute, EditProductDetailAttributeDTO>();
            CreateMap<EditProductDetailAttributeDTO, ProductDetailAttribute>();
            CreateMap<ProductDetailAttribute, CreateProductDetailAttributeDTO>();
            CreateMap<CreateProductDetailAttributeDTO, ProductDetailAttribute>();
            CreateMap<ProductDetailAttributeTranslate, ProductDetailAttributeTranslateDTO>();
            CreateMap<ProductDetailAttributeTranslateDTO, ProductDetailAttributeTranslate>();

            CreateMap<Advert, AdvertDTO>();
            CreateMap<AdvertDTO, Advert>();
            CreateMap<Advert, AdvertListDTO>();
            CreateMap<AdvertListDTO, Advert>();
            CreateMap<Advert, CreateAdvertDTO>();
            CreateMap<CreateAdvertDTO, Advert>();
            CreateMap<Advert, EditAdvertDTO>();
            CreateMap<EditAdvertDTO, Advert>();

            CreateMap<AdvertTranslate, AdvertTranslateDTO>();
            CreateMap<AdvertTranslateDTO, AdvertTranslate>();

            CreateMap<ApplicationUser, ApplicationUserDTO>();
            CreateMap<ApplicationUserDTO, ApplicationUser>();
            CreateMap<ApplicationUser, ApplicationUserListDTO>()
                .ForMember(p => p.OrganizationName, from => from.MapFrom(p => p.Organization.Name));
            CreateMap<ApplicationUserListDTO, ApplicationUser>();
            CreateMap<ApplicationUser, CreateApplicationUserDTO>();
            CreateMap<CreateApplicationUserDTO, ApplicationUser>();
            CreateMap<ApplicationUser, EditApplicationUserDTO>();
            CreateMap<EditApplicationUserDTO, ApplicationUser>();

            CreateMap<Comment, CommentDto>();
            CreateMap<CommentDto, Comment>();
            CreateMap<Comment, CommentListDto>();
            CreateMap<CommentListDto, Comment>();
            CreateMap<Comment, CommentCreateDto>();
            CreateMap<CommentCreateDto, Comment>();
            CreateMap<Comment, CommentEditDto>();
            CreateMap<CommentEditDto, Comment>();

            CreateMap<ProductComment, ProductCommentDto>();
            CreateMap<ProductCommentDto, ProductComment>();
            CreateMap<ProductComment, ProductCommentListDto>();
            CreateMap<ProductCommentListDto, ProductComment>();
            CreateMap<ProductComment, ProductCommentCreateDto>();
            CreateMap<ProductCommentCreateDto, ProductComment>();
            CreateMap<ProductComment, ProductCommentEditDto>();
            CreateMap<ProductCommentEditDto, ProductComment>();

            CreateMap<StoreComment, StoreCommentDto>();
            CreateMap<StoreCommentDto, StoreComment>();
            CreateMap<StoreComment, StoreCommentListDto>();
            CreateMap<StoreCommentListDto, StoreComment>();
            CreateMap<StoreComment, StoreCommentCreateDto>();
            CreateMap<StoreCommentCreateDto, StoreComment>();
            CreateMap<StoreComment, StoreCommentEditDto>();
            CreateMap<StoreCommentEditDto, StoreComment>();

            CreateMap<Bookmark, BookmarkDto>();
            CreateMap<BookmarkDto, Bookmark>();
            CreateMap<Bookmark, BookmarkListDto>();
            CreateMap<BookmarkListDto, Bookmark>();
            CreateMap<Bookmark, BookmarkCreateDto>();
            CreateMap<BookmarkCreateDto, Bookmark>();

            CreateMap<Basket, BasketDto>();
            CreateMap<BasketDto, Basket>();
            CreateMap<Basket, BasketListDto>();
            CreateMap<BasketListDto, Basket>();
            CreateMap<Basket, BasketCreateDto>();
            CreateMap<BasketCreateDto, Basket>();
            CreateMap<Basket, BasketEditDto>();
            CreateMap<BasketEditDto, Basket>();

            CreateMap<Language, LanguageDTO>();
            CreateMap<LanguageDTO, Language>();
        }
    }
}
