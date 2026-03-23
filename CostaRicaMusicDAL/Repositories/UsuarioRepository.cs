using CostaRicaMusicDAL.Data;
using CostaRicaMusicDAL.Entidades;
namespace CostaRicaMusicDAL.Repositories;
public class UsuarioRepository : IUsuarioRepository
{
    private readonly List<Usuario> _usuarios = SeedData.Usuarios;
    public Usuario? GetByCredentials(string email, string password) =>
        _usuarios.FirstOrDefault(x => x.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && x.Password == password);
}
