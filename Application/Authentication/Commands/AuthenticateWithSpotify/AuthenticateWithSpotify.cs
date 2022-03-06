using MediatR;

namespace Application.Authentication.Commands.AuthenticateWithSpotify;

public static class AuthenticateWithSpotify
{
    public record Response(string Message);

    public record Request : IRequest<Response>;
    
    public class Handler : IRequestHandler<Request, Response>
    {
        public Handler()
        {
            
        }
        
        public Task<Response> Handle(Request request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new Response("OK"));
        }
    }
}