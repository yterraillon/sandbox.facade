using MediatR;

namespace Application.Authentication.Events;

public record AuthenticatedWithSpotify(string Token) : INotification;