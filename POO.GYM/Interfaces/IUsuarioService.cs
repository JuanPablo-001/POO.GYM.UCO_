using POO.GYM.Models;

namespace POO.GYM.Interfaces
{
    public interface IUsuarioService
    {
        List<Usuario> ObtenerUsuarios();
        Usuario CrearUsuario(Usuario usuario);
    }
}