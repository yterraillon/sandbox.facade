using Application.Authentication.Commands.AuthenticateWithSpotify;

namespace SpotifyWebApi.Authentication;

public class SpotifyAuthenticationFacade : ISpotifyAuthenticationFacade
{
    private readonly AuthenticationUrlBuilder _authenticationUrlBuilder;
    private readonly State _state;

    public SpotifyAuthenticationFacade(AuthenticationUrlBuilder authenticationUrlBuilder, State state)
    {
        _authenticationUrlBuilder = authenticationUrlBuilder;
        _state = state;
    }

    public string BuildAuthenticationUrl()
    {
        var state = _state.GenerateState();
        return _authenticationUrlBuilder.BuildAuthenticationUrl(state);
    }
}