using MediatR;

namespace Application.Authentication.Commands.AuthenticateWithSpotify;

public static class AuthenticateWithSpotify
{
    public record Response(string Message);

    public record Request : IRequest<Response>;
    
    public class Handler : IRequestHandler<Request, Response>
    {
        private readonly ISpotifyAuthenticationFacade _authenticationFacade;

        public Handler(ISpotifyAuthenticationFacade authenticationFacade) => _authenticationFacade = authenticationFacade;

        public Task<Response> Handle(Request request, CancellationToken cancellationToken)
        {
            var url = _authenticationFacade.BuildAuthenticationUrl();
            return Task.FromResult(new Response(url));
        }
    }
}