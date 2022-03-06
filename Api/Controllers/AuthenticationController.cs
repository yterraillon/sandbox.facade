using Application.Authentication.Commands.AuthenticateWithSpotify;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IMediator _mediator;

    public AuthenticationController(IMediator mediator) => _mediator = mediator;

    [HttpPost]
    public async Task<IActionResult> AuthenticateWithSpotify()
    {
        var response = await _mediator.Send(new AuthenticateWithSpotify.Request());
        return Ok(response);
    }
}
