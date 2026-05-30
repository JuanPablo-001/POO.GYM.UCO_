using POO.GYM.Interfaces;
using POO.GYM.Models;

namespace POO.GYM.Services
{
    public class UsuarioService : IUsuarioService
    {
        private static List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario
            {
                IdUsuario = 1,
                Nombre = "Tomás",
                Correo = "tomas@gym.com",
                Contrasena = "123456",
                Objetivo = "Hipertrofia",
                EstadoFisico = "Intermedio",
                FechaRegistro = DateTime.Now
            },

            new Usuario
            {
                IdUsuario = 2,
                Nombre = "Carlos Gómez",
                Correo = "carlos@gym.com",
                Contrasena = "123456",
                Objetivo = "Pérdida de peso",
                EstadoFisico = "Principiante",
                FechaRegistro = DateTime.Now
            },

            new Usuario
            {
                IdUsuario = 3,
                Nombre = "Laura Martínez",
                Correo = "laura@gym.com",
                Contrasena = "123456",
                Objetivo = "Resistencia",
                EstadoFisico = "Avanzado",
                FechaRegistro = DateTime.Now
            },

            new Usuario
            {
                IdUsuario = 4,
                Nombre = "Juan Torres",
                Correo = "juan@gym.com",
                Contrasena = "123456",
                Objetivo = "Ganancia muscular",
                EstadoFisico = "Intermedio",
                FechaRegistro = DateTime.Now
            },

            new Usuario
            {
                IdUsuario = 5,
                Nombre = "Valentina Ruiz",
                Correo = "valentina@gym.com",
                Contrasena = "123456",
                Objetivo = "Tonificación",
                EstadoFisico = "Principiante",
                FechaRegistro = DateTime.Now
            },

            new Usuario
            {
                IdUsuario = 6,
                Nombre = "Andrés Pérez",
                Correo = "andres@gym.com",
                Contrasena = "123456",
                Objetivo = "Fuerza",
                EstadoFisico = "Avanzado",
                FechaRegistro = DateTime.Now
            }
        };

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarios;
        }

        public Usuario CrearUsuario(Usuario usuario)
        {
            usuario.IdUsuario = usuarios.Count + 1;
            usuario.FechaRegistro = DateTime.Now;

            usuarios.Add(usuario);

            return usuario;
        }
    }
}