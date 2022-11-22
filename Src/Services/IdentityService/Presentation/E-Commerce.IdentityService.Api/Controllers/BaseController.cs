using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.IdentityService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BaseController : ControllerBase
    {
        protected IMediator _mediator => Mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        private IMediator Mediator;


    }
}
