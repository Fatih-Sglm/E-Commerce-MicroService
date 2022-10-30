using E_Commerce.CatalogService.Application.Features.CatalogItems.Command.CreatCatalogItem;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Command.DeleteCatalogItem;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Command.UpdateCatalogItem;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Queries.GetCatalogItem;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Queries.GetListCatalogItem;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.CatalogService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogItemController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreatCatalogItemCommand creatCatalogItemCommand)
        {
            return Ok(await Mediator.Send(creatCatalogItemCommand));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] UpdateCatalogItemCommand updateCatalogItemCommand)
        {
            return Ok(await Mediator.Send(updateCatalogItemCommand));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get([FromQuery] GetListCatalogItemQuery getListCatalogItemCommand)
        {
            return Ok(await Mediator.Send(getListCatalogItemCommand));
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetCatalogItemQuery getCatalogItemQuery)
        {
            return Ok(await Mediator.Send(getCatalogItemQuery));
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteCatalogItemCommand deleteCatalogItemCommand)
        {
            return Ok(await Mediator.Send(deleteCatalogItemCommand));
        }
    }
}
