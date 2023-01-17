using E_Commerce.CatalogService.Application.Abstractions.Services.CatalogItems;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos;
using E_Commerce.CatalogService.Application.Models;
using MediatR;

namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Command.UpdateCatalogItem
{
    public class UpdateCatalogItemCommand : IRequest<ResponseDto<NoContent>>
    {
        public UpdateCatalogItemDto updateCatalogItem { get; set; }
        public class UpdateCatalogItemCommandHandler : IRequestHandler<UpdateCatalogItemCommand, ResponseDto<NoContent>>
        {
            private readonly ICatalogItemWriteService _catalogItemsService;

            public UpdateCatalogItemCommandHandler(ICatalogItemWriteService catalogItemsService)
            {
                _catalogItemsService = catalogItemsService;
            }

            public async Task<ResponseDto<NoContent>> Handle(UpdateCatalogItemCommand request, CancellationToken cancellationToken)
            {
                await _catalogItemsService.UpdateProduct(request.updateCatalogItem);
                return ResponseDto<NoContent>.SuccesWithOutData("Ürün Güncellendi");
            }
        }
    }
}
