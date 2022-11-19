using AutoMapper;
using E_Commerce.CatalogService.Application.Abstractions.Services;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos;
using E_Commerce.CatalogService.Application.Features.Common;
using MediatR;

namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Command.UpdateCatalogItem
{
    public class UpdateCatalogItemCommand : IRequest<ResponseDto<NoContent>>
    {
        public UpdateCatalogItemDto updateCatalogItem { get; set; }
        public class UpdateCatalogItemCommandHandler : IRequestHandler<UpdateCatalogItemCommand, ResponseDto<NoContent>>
        {
            private readonly ICatalogItemsService _catalogItemsService;
            private readonly ICatalogItemImageService _catalogItemImageService;
            private readonly IMapper _mapper;

            public UpdateCatalogItemCommandHandler(ICatalogItemsService catalogItemsService, ICatalogItemImageService catalogItemImageService, IMapper mapper)
            {
                _catalogItemsService = catalogItemsService;
                _catalogItemImageService = catalogItemImageService;
                _mapper = mapper;
            }

            public async Task<ResponseDto<NoContent>> Handle(UpdateCatalogItemCommand request, CancellationToken cancellationToken)
            {
                await _catalogItemsService.UpdateProduct(request.updateCatalogItem);
                return ResponseDto<NoContent>.SuccesWithOutData("Ürün Güncellendi");
            }
        }
    }
}
