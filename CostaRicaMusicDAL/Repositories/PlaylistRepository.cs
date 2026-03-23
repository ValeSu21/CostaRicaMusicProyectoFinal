using CostaRicaMusicDAL.Data;
using CostaRicaMusicDAL.Entidades;
namespace CostaRicaMusicDAL.Repositories;
public class PlaylistRepository : IPlaylistRepository
{
    private static readonly List<Playlist> _playlists = SeedData.Playlists;
    public IEnumerable<Playlist> GetByUser(string email) => _playlists.Where(x => x.UsuarioEmail.Equals(email, StringComparison.OrdinalIgnoreCase));
    public Playlist? GetById(int id) => _playlists.FirstOrDefault(x => x.IdPlaylist == id);
    public Playlist Create(Playlist playlist)
    {
        playlist.IdPlaylist = _playlists.Any() ? _playlists.Max(x => x.IdPlaylist) + 1 : 1;
        _playlists.Add(playlist);
        return playlist;
    }
    public void Update(Playlist playlist)
    {
        var actual = GetById(playlist.IdPlaylist);
        if (actual is null) return;
        actual.Nombre = playlist.Nombre;
        actual.Descripcion = playlist.Descripcion;
        actual.CancionesIds = playlist.CancionesIds;
    }
    public void Delete(int id)
    {
        var actual = GetById(id);
        if (actual is not null) _playlists.Remove(actual);
    }
}
