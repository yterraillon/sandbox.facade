using Application.Authentication.Commands.AuthenticateWithSpotify;
using Application.Playlists;
using Microsoft.Extensions.DependencyInjection;
using SpotifyWebApi.Authentication;
using SpotifyWebApi.Playlists;

namespace SpotifyWebApi;

public static class DependencyInjection
{
    public static IServiceCollection AddSpotifyWebApi(this IServiceCollection services)
    {
        services.AddTransient<AuthenticationUrlBuilder>();
        services.AddSingleton<State>();
        services.AddTransient<ISpotifyAuthenticationFacade, SpotifyAuthenticationFacade>();
        services.AddTransient<IPlaylistsFacade, PlaylistsFacade>();
        
        return services;
    }
}