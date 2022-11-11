﻿using E_Commerce.CatalogService.Application.Abstractions.Services;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Models;
using E_Commerce.CatalogService.Application.Features.Common;
using E_Commerce.CatalogService.Application.Paging;
using MediatR;

namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Queries.GetCatalogItemsByBrand
{
    public class GetCatalogItemsByBrandQuery : IRequest<ResponseDto<CatalogItemListModel>>
    {
        public PageRequest? PageRequest { get; set; } = new PageRequest(0, 5);

        public uint BrandId { get; set; }

        public class GetCatalogItemsByBrandQueryHandler : IRequestHandler<GetCatalogItemsByBrandQuery, ResponseDto<CatalogItemListModel>>
        {
            private readonly ICatalogItemsService _catalogItemsService;

            public GetCatalogItemsByBrandQueryHandler(ICatalogItemsService catalogItemsService)
            {
                _catalogItemsService = catalogItemsService;
            }

            public async Task<ResponseDto<CatalogItemListModel>> Handle(GetCatalogItemsByBrandQuery request, CancellationToken cancellationToken)
            {
                CatalogItemListModel model = await _catalogItemsService.GetListCatalogItemByBrand(request.PageRequest, request.BrandId);
                return ResponseDto<CatalogItemListModel>(model);
            }
        }
    }
}
