namespace SpotifyWebApi.Authentication;

public  class AuthenticationUrlBuilder
{
    public string BuildAuthenticationUrl(string state) => $"http://login.spotify.com?s={state}";
}