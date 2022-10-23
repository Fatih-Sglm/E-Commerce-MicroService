using E_Commerce.CatalogService.Application.Abstractions.Services;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos;
using E_Commerce.CatalogService.Application.Features.Common;
using MediatR;

namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Queries.GetCatalogItem
{
    public class GetCatalogItemQuery : IRequest<ResponseDto<GetCatalogItemDto>>
    {
        public int Id { get; set; }

        public class GetCatalogItemQueryHandler : IRequestHandler<GetCatalogItemQuery, ResponseDto<GetCatalogItemDto>>
        {
            private readonly ICatalogItemsService _catalogItemsService;

            public GetCatalogItemQueryHandler(ICatalogItemsService catalogItemsService)
            {
                _catalogItemsService = catalogItemsService;
            }

            public async Task<ResponseDto<GetCatalogItemDto>> Handle(GetCatalogItemQuery request, CancellationToken cancellationToken)
            {
                return ResponseDto<GetCatalogItemDto>.SuccesWithData(await _catalogItemsService.GetCatalogItem(request.Id));
            }
        }
    }
}
