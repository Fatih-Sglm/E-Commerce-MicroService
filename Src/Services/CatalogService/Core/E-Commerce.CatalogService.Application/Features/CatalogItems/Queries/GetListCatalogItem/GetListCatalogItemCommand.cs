using E_Commerce.CatalogService.Application.Abstractions.Services.CatalogItems;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Models;
using E_Commerce.CatalogService.Application.Models;
using E_Commerce.CatalogService.Application.Models.DynamicQuery;
using E_Commerce.CatalogService.Application.Paging;
using MediatR;

namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Queries.GetListCatalogItem
{
    public class GetListCatalogItemQuery : PageRequest, IRequest<ResponseDto<CatalogItemListModel>>
    {
        public Dynamic? Dynamic { get; set; }
        //public string[] Roles => new[] { "Admin" };
        public class GetListCatalogItemQueryHandler : IRequestHandler<GetListCatalogItemQuery, ResponseDto<CatalogItemListModel>>
        {
            private readonly ICatalogItemReadService _catalogItemsService;

            public GetListCatalogItemQueryHandler(ICatalogItemReadService catalogItemsService)
            {
                _catalogItemsService = catalogItemsService;
            }
            public async Task<ResponseDto<CatalogItemListModel>> Handle(GetListCatalogItemQuery request, CancellationToken cancellationToken)
            {
                CatalogItemListModel model;
                if (request.Dynamic != null)
                {
                    model = await _catalogItemsService.GetListCatalogItemDynamic(request.Dynamic, new() { Page = request.Page, PageSize = request.PageSize });
                }
                else
                {
                    model = await _catalogItemsService.GetListCatalogItem(new() { Page = request.Page, PageSize = request.PageSize });
                }

                return ResponseDto<CatalogItemListModel>.SuccesWithData(model);
            }
        }
    }
}
