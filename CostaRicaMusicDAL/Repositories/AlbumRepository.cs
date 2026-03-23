using CostaRicaMusicDAL.Data;
using CostaRicaMusicDAL.Entidades;
namespace CostaRicaMusicDAL.Repositories;
public class AlbumRepository : IAlbumRepository
{
    private readonly List<Album> _albumes = SeedData.Albumes;
    public IEnumerable<Album> GetAll() => _albumes.OrderBy(x => x.Titulo);
    public Album? GetById(int id) => _albumes.FirstOrDefault(x => x.IdAlbum == id);
}
