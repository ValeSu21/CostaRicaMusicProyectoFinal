using CostaRicaMusicDAL.Data;
using CostaRicaMusicDAL.Entidades;
namespace CostaRicaMusicDAL.Repositories;
public class ArtistaRepository : IArtistaRepository
{
    private readonly List<Artista> _artistas = SeedData.Artistas;
    public IEnumerable<Artista> GetAll() => _artistas.OrderBy(x => x.Nombre);
    public Artista? GetById(int id) => _artistas.FirstOrDefault(x => x.IdArtista == id);
}
