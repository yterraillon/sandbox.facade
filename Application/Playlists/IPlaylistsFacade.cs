namespace Application.Playlists;

public interface IPlaylistsFacade
{
    IEnumerable<Playlist> GetPlaylists();
}