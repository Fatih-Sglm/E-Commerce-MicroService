﻿using E_Commerce.CatalogService.Application.Features.CatalogItems.Command.CreatCatalogItem;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Command.DeleteCatalogItem;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Command.UpdateCatalogItem;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Queries.GetCatalogItem;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Queries.GetCatalogItemsByBrand;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Queries.GetCatalogItemsByCategory;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Queries.GetListCatalogItem;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.CatalogService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogItemController : BaseController
    {
        [HttpPost("AddCatalogItem")]
        public async Task<IActionResult> Create([FromForm] CreatCatalogItemCommand creatCatalogItemCommand)
        {
            return Ok(await Mediator.Send(creatCatalogItemCommand));
        }

        [HttpPut("UpdateCatalogItem")]
        public async Task<IActionResult> Update([FromForm] UpdateCatalogItemCommand updateCatalogItemCommand)
        {
            return Ok(await Mediator.Send(updateCatalogItemCommand));
        }

        [HttpGet("GetCatalogList")]
        public async Task<IActionResult> Get([FromQuery] GetListCatalogItemQuery getListCatalogItemCommand)
        {
            return Ok(await Mediator.Send(getListCatalogItemCommand));
        }

        [HttpGet("GetCatalogItem/{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetCatalogItemQuery getCatalogItemQuery)
        {
            return Ok(await Mediator.Send(getCatalogItemQuery));
        }


        [HttpGet("GetCatalogItemsByType")]
        public async Task<IActionResult> GetCatalogItemsByType([FromQuery] GetCatalogItemsByTypeQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [HttpGet("GetCatalogItemsByBrand")]
        public async Task<IActionResult> GetCatalogItemsByBrand([FromQuery] GetCatalogItemsByBrandQuery query)
        {
            return Ok(await Mediator.Send(query));
        }


        [HttpDelete("DeleteCatalogItem/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteCatalogItemCommand deleteCatalogItemCommand)
        {
            return Ok(await Mediator.Send(deleteCatalogItemCommand));
        }
    }
}
