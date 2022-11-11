using E_Commerce.CatalogService.Application.Abstractions.Services;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Models;
using E_Commerce.CatalogService.Application.Features.Common;
using E_Commerce.CatalogService.Application.Paging;
using MediatR;

namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Queries.GetCatalogItemsByCategory
{
    public class GetCatalogItemsByTypeQuery : IRequest<ResponseDto<CatalogItemListModel>>
    {
        public PageRequest? pageRequest { get; set; } = new PageRequest(0, 5);
        public uint CategoryId { get; set; }

        public class GetCatalogItemsByTypeQueryHandler : IRequestHandler<GetCatalogItemsByTypeQuery, ResponseDto<CatalogItemListModel>>
        {
            private readonly ICatalogItemsService _catalogItemsService;

            public GetCatalogItemsByTypeQueryHandler(ICatalogItemsService catalogItemsService)
            {
                _catalogItemsService = catalogItemsService;
            }

            public async Task<ResponseDto<CatalogItemListModel>> Handle(GetCatalogItemsByTypeQuery request, CancellationToken cancellationToken)
            {
                CatalogItemListModel? model = await _catalogItemsService.GetListCatalogItemByType(request.pageRequest, request.CategoryId);
                return ResponseDto<CatalogItemListModel>.SuccesWithData(model);
            }
        }
    }
}
