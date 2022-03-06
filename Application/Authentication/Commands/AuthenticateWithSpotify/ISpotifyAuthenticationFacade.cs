namespace Application.Authentication.Commands.AuthenticateWithSpotify;

public interface ISpotifyAuthenticationFacade
{
    string BuildAuthenticationUrl();
}