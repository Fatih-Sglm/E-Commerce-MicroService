using E_Commerce.CatalogService.Application.Abstractions.Services;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Models;
using E_Commerce.CatalogService.Application.Features.Common;
using E_Commerce.CatalogService.Application.Paging;
using MediatR;

namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Queries.GetListCatalogItem
{
    public class GetListCatalogItemQuery : PageRequest, IRequest<ResponseDto<CatalogItemListModel>>
    {
        public class GetListCatalogItemQueryHandler : IRequestHandler<GetListCatalogItemQuery, ResponseDto<CatalogItemListModel>>
        {
            private readonly ICatalogItemsService _catalogItemsService;

            public GetListCatalogItemQueryHandler(ICatalogItemsService catalogItemsService)
            {
                _catalogItemsService = catalogItemsService;
            }

            public async Task<ResponseDto<CatalogItemListModel>> Handle(GetListCatalogItemQuery request, CancellationToken cancellationToken)
            {

                return ResponseDto<CatalogItemListModel>.SuccesWithData(await _catalogItemsService.GetListCatalogItem(new() { Page = request.Page, PageSize = request.PageSize }));
            }
        }
    }
}
