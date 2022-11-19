using E_Commerce.CatalogService.Application.Abstractions.Services;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos;
using E_Commerce.CatalogService.Application.Features.Common;
using MediatR;

namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Command.CreatCatalogItem
{
    public class CreatCatalogItemCommand : IRequest<ResponseDto<NoContent>>
    {
        public CreateCatalogItemDto CreateCatalogItemDto { get; set; }


        public class CreatCatalogItemCommandHandler : IRequestHandler<CreatCatalogItemCommand, ResponseDto<NoContent>>
        {
            private readonly ICatalogItemsService _catalogItemsService;

            public CreatCatalogItemCommandHandler(ICatalogItemsService catalogItemsService)
            {
                _catalogItemsService = catalogItemsService;
            }

            public async Task<ResponseDto<NoContent>> Handle(CreatCatalogItemCommand request, CancellationToken cancellationToken)
            {
                await _catalogItemsService.CreateProduct(request.CreateCatalogItemDto);
                return ResponseDto<NoContent>.SuccesWithOutData("ürün Eklendi");
            }
        }
    }
}
