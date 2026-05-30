using POO.GYM.Interfaces;
using POO.GYM.Models;

namespace POO.GYM.Services
{
    public class AdministradorService : IAdministradorService
    {
        private static List<Administrador> administradores = new();

        public List<Administrador> ObtenerAdministradores()
        {
            return administradores;
        }

        public Administrador CrearAdministrador(Administrador administrador)
        {
            administrador.IdAdministrador = administradores.Count + 1;
            administradores.Add(administrador);

            return administrador;
        }
    }
}