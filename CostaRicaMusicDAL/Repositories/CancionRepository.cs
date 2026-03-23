using CostaRicaMusicDAL.Data;
using CostaRicaMusicDAL.Entidades;
namespace CostaRicaMusicDAL.Repositories;
public class CancionRepository : ICancionRepository
{
    private readonly List<Cancion> _canciones = SeedData.Canciones;
    public IEnumerable<Cancion> GetAll() => _canciones.OrderBy(x => x.Nombre);
    public Cancion? GetById(int id) => _canciones.FirstOrDefault(x => x.IdCancion == id);
}
