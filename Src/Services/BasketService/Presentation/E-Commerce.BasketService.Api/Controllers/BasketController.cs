﻿using E_Commerce.BasketService.Application.Abstractions.Services;
using E_Commerce.BasketService.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.BasketService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _service;

        public BasketController(IBasketService service)
        {
            _service = service;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetBasket(string Id)
        {
            return Ok(await _service.GetBasketById(Id));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] CustomerBasket basket)
        {
            return Ok(await _service.UpdateBasketAsync(basket));
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] BasketItem basketItem)
        {
            await _service.AddItemToBasket(basketItem);
            return Ok();
        }

        [HttpPost("CheckOut")]
        public async Task<IActionResult> CheckOut([FromBody] BasketCheckout basketCheckout)
        {
            await _service.CheckOutAsync(basketCheckout);
            return Accepted();
        }

        [HttpDelete("{Id}")]
        public async Task CheckOut(string Id)
        {
            await _service.DeleteBasketByIdAsync(Id);
        }
    }
}
