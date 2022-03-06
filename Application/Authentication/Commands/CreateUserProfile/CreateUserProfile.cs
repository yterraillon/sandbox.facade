using Application.Authentication.Events;
using MediatR;

namespace Application.Authentication.Commands.CreateUserProfile;

public class CreateUserProfile : INotificationHandler<AuthenticatedWithSpotify>
{
    public Task Handle(AuthenticatedWithSpotify notification, CancellationToken cancellationToken)
    {
        Console.WriteLine("LOGGED IN");
        return Task.CompletedTask;
    }
}