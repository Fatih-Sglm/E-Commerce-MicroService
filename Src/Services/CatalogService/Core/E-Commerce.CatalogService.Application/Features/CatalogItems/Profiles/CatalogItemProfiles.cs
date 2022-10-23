using AutoMapper;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Models;
using E_Commerce.CatalogService.Application.Paging;
using E_Commerce.CatalogService.Domain.Entity;

namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Profiles
{
    public class CatalogItemProfiles : Profile
    {
        public CatalogItemProfiles()
        {
            CreateMap<CreateCatalogItemDto, CatalogItem>();
            CreateMap<CreateCatalogItemFeaturesDto, CatalogItemFeature>();
            CreateMap<IPaginate<CatalogItem>, CatalogItemListModel>();
            CreateMap<CatalogItem, GetListCatalogItemDto>().
                ForMember(x => x.CatalogTypeName, y => y.MapFrom(z => z.CatalogType.Type)).
                ForMember(x => x.CatalogBrandName, y => y.MapFrom(z => z.CatalogBrand.Brand)).ForMember(x => x.CatalogItemsHeaderImage, y => y.MapFrom(z => z.CatalogItemImages.Where(x => x.IsHeader == true).Select(x => x.PictureFileName)));
            CreateMap<CatalogItem, GetCatalogItemDto>().
                ForMember(x => x.CatalogTypeName, y => y.MapFrom(z => z.CatalogType.Type)).
                ForMember(x => x.CatalogBrandName, y => y.MapFrom(z => z.CatalogBrand.Brand)).
                ForMember(x => x.CatalogItemsImages, y => y.MapFrom(z => z.CatalogItemImages.Select(x => x.PictureFileName))).
                ForMember(x => x.BodySize, y => y.MapFrom(z => z.CatalogItemFeature.BodySize!.ToString())).
                ForMember(x => x.AvailableStock, y => y.MapFrom(z => z.CatalogItemFeature.AvailableStock)).
                ForMember(x => x.Genders, y => y.MapFrom(z => z.CatalogItemFeature.Genders.ToString())).
                ForMember(x => x.Size, y => y.MapFrom(z => z.CatalogItemFeature.Size));

        }
    }
}
