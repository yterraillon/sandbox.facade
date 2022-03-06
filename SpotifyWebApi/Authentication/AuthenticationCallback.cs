using Application;
using Application.Authentication.Events;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace SpotifyWebApi.Authentication;

public class AuthenticationCallback: EndpointBaseAsync
    .WithRequest<string>
    .WithActionResult<string>
{
    private readonly IEventBus _eventBus;

    public AuthenticationCallback(IEventBus eventBus) => _eventBus = eventBus;

    [HttpPost("/spotify/callback")]
    [SwaggerOperation(
        Summary = "Handles Spotify Callback",
        Description = "Handles Spotify Callback",
        OperationId = "SpotifyAuthCallback", 
        Tags = new []{ "Spotify"})]
    public override async Task<ActionResult<string>> HandleAsync(string request, CancellationToken cancellationToken = new CancellationToken())
    {
        const string tokens = "1234";
        await _eventBus.Publish(new AuthenticatedWithSpotify(tokens));
        
        return Ok();
    }
}