using E_Commerce.OrderService.Application.Features.Order.Command.CreateOrder;
using E_Commerce.OrderService.Application.Features.Order.Queries.GetOrderById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.OrderService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{OrderId}")]
        public async Task<IActionResult> GetOrderDetail([FromRoute] GetOrderByIdQuery getOrderByIdQuery)
        {
            return Ok(await _mediator.Send(getOrderByIdQuery));
        }

        [HttpGet("")]
        public async Task<IActionResult> Bla()
        {
            CreateOrderCommand createOrderCommand = new() { };
            await _mediator.Send(createOrderCommand);
            return Ok();
        }
    }
}
