using eAppointment.Application.Features.Auth.Login;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eAppointment.WebAPI.Controllers
{
    [Route("api/[controller]/action")]
    [ApiController]
    public class AuthController(IMediator mediator) : ControllerBase
    {
        [HttpPost] 
        public async Task<IActionResult> Login(LoginCommand request,CancellationToken cancellationToken)
        {
            var response = await mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode,response);
        }

    }
}
