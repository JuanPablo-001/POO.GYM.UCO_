using POO.GYM.Models;

namespace POO.GYM.Interfaces
{
    public interface IAdministradorService
    {
        List<Administrador> ObtenerAdministradores();
        Administrador CrearAdministrador(Administrador administrador);
    }
}