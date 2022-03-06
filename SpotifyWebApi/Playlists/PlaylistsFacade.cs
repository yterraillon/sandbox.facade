using Application.Playlists;

namespace SpotifyWebApi.Playlists;

public class PlaylistsFacade : IPlaylistsFacade
{
    public IEnumerable<Playlist> GetPlaylists()
    {
        return Enumerable.Empty<Playlist>();
    }
}