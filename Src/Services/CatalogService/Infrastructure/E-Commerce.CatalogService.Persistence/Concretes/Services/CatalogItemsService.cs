using AutoMapper;
using E_Commerce.CatalogService.Application.Abstractions.Repositories;
using E_Commerce.CatalogService.Application.Abstractions.Services;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Models;
using E_Commerce.CatalogService.Application.Paging;
using E_Commerce.CatalogService.Domain.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.CatalogService.Persistence.Concretes.Services
{
    public class CatalogItemsService : ICatalogItemsService
    {
        private readonly ICatalogItemRepository _catalogItemRepository;
        private readonly IMapper _mapper;
        private readonly ICatalogItemImageService _catalogItemImageService;
        private readonly string webrootPath;
        public CatalogItemsService(ICatalogItemRepository catalogItemRepository, IMapper mapper, ICatalogItemImageService catalogItemImageService
            , IWebHostEnvironment env)
        {
            _catalogItemRepository = catalogItemRepository;
            _mapper = mapper;
            _catalogItemImageService = catalogItemImageService;
            webrootPath = env.WebRootPath;
        }

        public async Task CreateProduct(CreateCatalogItemDto createCatalogItemDto, CreateCatalogItemFeaturesDto createCatalogItemFeaturesDto)
        {
            CatalogItem catalogItem = _mapper.Map<CatalogItem>(createCatalogItemDto);
            CatalogItemFeature catalogItemFeature = _mapper.Map<CatalogItemFeature>(createCatalogItemFeaturesDto);
            catalogItem.CatalogItemFeature = catalogItemFeature;
            await _catalogItemRepository.AddAsync(catalogItem);
            await _catalogItemImageService.CreateCatalogItemImage(catalogItem.Id, createCatalogItemDto.ImagesPath!);
        }

        public Task<CatalogItem> GetByIdWithImage(int CatalogItemId)
        {
            return _catalogItemRepository.GetAsync(x => x.Id == CatalogItemId, c => c.Include(c => c.CatalogItemImages));
        }

        public async Task<GetCatalogItemDto> GetCatalogItem(int CatalogItemId)
        {
            CatalogItem? catalogItem = await _catalogItemRepository.GetAsync(x => x.Id == CatalogItemId, include:
                    c => c.Include(x => x.CatalogBrand).Include(c => c.CatalogType).Include(x => x.CatalogItemFeature).Include(x => x.CatalogItemImages));

            GetCatalogItemDto getCatalogItemDto = _mapper.Map<GetCatalogItemDto>(catalogItem);
            SetWebRoothImage(getCatalogItemDto.CatalogItemsImages);

            return getCatalogItemDto;
        }

        public async Task<CatalogItemListModel> GetListCatalogItem(PageRequest pageRequest)
        {
            IPaginate<CatalogItem> CatalogItems = await _catalogItemRepository.
            GetListAsync(index: pageRequest.Page, size: pageRequest.PageSize, include: c => c.Include(c => c.CatalogBrand).Include(c => c.CatalogType).Include(c => c.CatalogItemFeature).Include(c => c.CatalogItemImages));
            CatalogItemListModel catalogItemListModel = _mapper.Map<CatalogItemListModel>(CatalogItems);
            SetWebRoothImage(catalogItemListModel.Items.SelectMany(x => x.CatalogItemsHeaderImage).ToList());
            return catalogItemListModel;
        }

        public async Task UpdateProduct(UpdateCatalogItemDto updateCatalogItemDto)
        {
            CatalogItem? catalogItem = await _catalogItemRepository.GetAsync(x => x.Id == updateCatalogItemDto.Id);
            catalogItem!.CatalogItemFeature = _mapper.Map<CatalogItemFeature>(updateCatalogItemDto.createCatalogItemFeaturesDto);
            await _catalogItemImageService.CreateCatalogItemImage(updateCatalogItemDto.Id, updateCatalogItemDto.createCatalogItemDto.ImagesPath!);
            await _catalogItemRepository.UpdateAsync(catalogItem);
        }

        private void SetWebRoothImage(IList<string> Images)
        {
            for (int i = 0; i < Images.Count; i++)
            {
                Images[i] = webrootPath + "\\" + Images[i];
            }
        }
    }
}
