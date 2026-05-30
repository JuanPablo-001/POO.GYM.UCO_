using POO.GYM.Interfaces;
using POO.GYM.Models;

namespace POO.GYM.Services
{
    public class EntrenadorService : IEntrenadorService
    {
        private static List<Entrenador> entrenadores = new()
        {
            new Entrenador
            {
                IdEntrenador = 1,
                Nombre = "Andrés Pérez",
                Correo = "andres@gym.com",
                Contrasena = "123456",
                Especialidad = "Musculación",
                Experiencia = 8,
                Usuarios = new List<Usuario>()
            },

            new Entrenador
            {
                IdEntrenador = 2,
                Nombre = "Valentina Ruiz",
                Correo = "valentina@gym.com",
                Contrasena = "123456",
                Especialidad = "CrossFit",
                Experiencia = 5,
                Usuarios = new List<Usuario>()
            },

            new Entrenador
            {
                IdEntrenador = 3,
                Nombre = "Juan Torres",
                Correo = "juan@gym.com",
                Contrasena = "123456",
                Especialidad = "Cardio",
                Experiencia = 10,
                Usuarios = new List<Usuario>()
            },

           
        

            new Entrenador
            {
                IdEntrenador = 5,
                Nombre = "Carlos Martínez",
                Correo = "carlos@gym.com",
                Contrasena = "123456",
                Especialidad = "Funcional",
                Experiencia = 7,
                Usuarios = new List<Usuario>()
            }
        };

        public List<Entrenador> ObtenerEntrenadores()
        {
            return entrenadores;
        }

        public Entrenador CrearEntrenador(Entrenador entrenador)
        {
            entrenador.IdEntrenador = entrenadores.Count + 1;

            if (entrenador.Usuarios == null)
                entrenador.Usuarios = new List<Usuario>();

            entrenadores.Add(entrenador);

            return entrenador;
        }
    }
}
    
