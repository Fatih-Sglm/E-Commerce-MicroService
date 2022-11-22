using AutoMapper;
using E_Commerce.CatalogService.Application.Abstractions.Repositories;
using E_Commerce.CatalogService.Application.Abstractions.Services;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Models;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Rules;
using E_Commerce.CatalogService.Application.Paging;
using E_Commerce.CatalogService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace E_Commerce.CatalogService.Persistence.Concretes.Services
{
    public class CatalogItemsService : ICatalogItemsService
    {
        private readonly ICatalogItemRepository _catalogItemRepository;
        private readonly IMapper _mapper;
        private readonly ICatalogItemImageService _catalogItemImageService;
        private readonly ICatalogTypeService _catalogTypeService;
        private readonly ICatalogBrandService _catalogBrandService;
        private readonly ICatalogItemVariantService _catalogItemVariantService;

        public CatalogItemsService(ICatalogItemRepository catalogItemRepository,
            IMapper mapper, ICatalogItemImageService catalogItemImageService,
            ICatalogTypeService catalogTypeService, ICatalogBrandService catalogBrandService, ICatalogItemVariantService catalogItemVariantService)
        {
            _catalogItemRepository = catalogItemRepository;
            _mapper = mapper;
            _catalogItemImageService = catalogItemImageService;
            _catalogTypeService = catalogTypeService;
            _catalogBrandService = catalogBrandService;
            _catalogItemVariantService = catalogItemVariantService;
        }

        public async Task CreateProduct(CreateCatalogItemDto createCatalogItemDto)
        {
            CatalogItem catalogItem = _mapper.Map<CatalogItem>(createCatalogItemDto);
            await SetCatalogItemVariant(catalogItem, createCatalogItemDto.Variants);
            catalogItem.CatalogItemImages = await _catalogItemImageService.CreateCatalogItemImage(catalogItem, createCatalogItemDto.FolderPath, createCatalogItemDto.ImagesPath!);
            await _catalogItemRepository.AddAsync(catalogItem);
            await _catalogItemRepository.SaveChangesAsync();
        }

        private async Task SetCatalogItemVariant(CatalogItem catalogItem, IList<uint> variants = null)
        {
            if (variants is not null)
            {
                foreach (var item in variants)
                {
                    CatalogItemVariant catalogItemVariant = await _catalogItemVariantService.GetCatalogItemVariant(item);
                    catalogItem.CatalogItemVariants.Add(catalogItemVariant);
                }
            }
            return;
        }

        public Task<CatalogItem?> GetByIdWithImage(uint CatalogItemId)
        {
            return _catalogItemRepository.GetAsync(x => x.Id == CatalogItemId, c => c.Include(c => c.CatalogItemImages));
        }

        public Task<CatalogItem> GetById(uint CatalogItemId)
        {
            return _catalogItemRepository.GetAsync(x => x.Id == CatalogItemId);
        }

        public async Task<GetCatalogItemDto> GetCatalogItem(uint CatalogItemId)
        {
            CatalogItem? catalogItem = await _catalogItemRepository.GetAsync(x => x.Id == CatalogItemId, include:
                    c => c.Include(x => x.CatalogBrand).Include(c => c.CatalogType).Include(x => x.CatalogItemVariants).Include(x => x.CatalogItemImages));

            await catalogItem.CannotNull("");
            // _mapper.ProjectTo<GetCatalogItemDto>();
            GetCatalogItemDto getCatalogItemDto = _mapper.Map<GetCatalogItemDto>(catalogItem);
            getCatalogItemDto.CatalogItemsVariants = catalogItem.CatalogItemVariants.Select(x => x.VariantName).ToArray();
            getCatalogItemDto.CatalogItemsImagesPath = await _catalogItemImageService.GetCatalogItemImage(catalogItem);
            return getCatalogItemDto;
        }

        public async Task<CatalogItemListModel> GetListCatalogItem(PageRequest pageRequest)
        {
            return await GetListCatalogItemCondition(pageRequest);
        }

        public async Task<CatalogItemListModel?> GetListCatalogItemByType(PageRequest pageRequest, uint catalogTypeId)
        {
            await _catalogTypeService.GetCategoryById(catalogTypeId);
            return await GetListCatalogItemCondition(pageRequest, x => x.CatalogTypeId == catalogTypeId);
        }

        private async Task<CatalogItemListModel> GetListCatalogItemCondition(PageRequest pageRequest, Expression<Func<CatalogItem, bool>>? predicate = null)
        {

            IPaginate<CatalogItem>? catalogItems = await _catalogItemRepository.
            GetListAsyncWithPaginate(predicate, index: pageRequest.Page, size: pageRequest.PageSize,
            include: c => c.Include(c => c.CatalogBrand).Include(c => c.CatalogType).Include(c => c.CatalogItemImages).
            Include(c => c.CatalogItemVariants), orderBy: x => x.OrderByDescending(x => x.CatalogBrand.Name));
            CatalogItemListModel catalogItemListModel = _mapper.Map<CatalogItemListModel>(catalogItems);
            if (catalogItemListModel is not null)
            {
                foreach (var item in catalogItemListModel.Items)
                {
                    item.CatalogItemsHeaderImages = await _catalogItemImageService.GetCatalogItemImageWithList(catalogItems.Items.Where(x => x.Id == item.Id).SelectMany(x => x.CatalogItemImages).Where(x => x.IsHeader == true).ToArray());
                }

            }
            return catalogItemListModel;
        }

        //private async Task<IQueryable<GetListCatalogItemDto>> Bls()
        //{
        //    var ct = await _catalogItemRepository.GetListAsync(include: c => c.Include(c => c.CatalogBrand).Include(c => c.CatalogType).Include(c => c.CatalogItemImages).
        //    Include(c => c.CatalogItemVariants).ThenInclude(x => x.VariantName));
        //    IQueryable<GetListCatalogItemDto> dto = _mapper.ProjectTo<GetListCatalogItemDto>(ct);
        //    foreach (var item in dto)
        //    {
        //        item.CatalogItemsHeaderImages = await _catalogItemImageService.GetCatalogItemImageWithList(ct.SelectMany(x => x.CatalogItemImages).Where(x => x.IsHeader == true).ToArray());
        //    }
        //}

        public async Task UpdateProduct(UpdateCatalogItemDto updateCatalogItemDto)
        {
            CatalogItem? catalogItem = await _catalogItemRepository.GetAsync(x => x.Id == updateCatalogItemDto.Id);
            //catalogItem!.CatalogItemFeature = _mapper.Map<CatalogItemFeature>(updateCatalogItemDto.createCatalogItemFeaturesDto);
            //await _catalogItemImageService.CreateCatalogItemImage(updateCatalogItemDto.Id, updateCatalogItemDto.createCatalogItemDto.ImagesPath!);
            await _catalogItemRepository.UpdateAsync(catalogItem);
        }


        public async Task<CatalogItemListModel?> GetListCatalogItemByBrand(PageRequest pageRequest, uint brandId)
        {
            await _catalogBrandService.CheckBrandIsNull(brandId);
            return await GetListCatalogItemCondition(pageRequest, x => x.CatalogBrandId == brandId);
        }

        public Task<CatalogItemListModel> GetListCatalogItemWithPaginate(PageRequest pageRequest)
        {
            throw new NotImplementedException();
        }

        public Task<CatalogItemListModel> GetListCatalogItem()
        {
            throw new NotImplementedException();
        }
    }
}
