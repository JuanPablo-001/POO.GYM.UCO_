using POO.GYM.Interfaces;
using POO.GYM.Models;

namespace POO.GYM.Services
{
    public class RutinaService : IRutinaService
    {
        private static List<Rutina> rutinas = new()
        {
            new Rutina
            {
                IdRutina = 1,
                Nombre = "Hipertrofia Nivel 1",
                Objetivo = "Ganancia muscular",
                Duracion = 60,
                Nivel = "Intermedio",
                Estado = true,
                Ejercicios = new List<Ejercicio>()
            },

            new Rutina
            {
                IdRutina = 2,
                Nombre = "Quema de Grasa",
                Objetivo = "Pérdida de peso",
                Duracion = 45,
                Nivel = "Principiante",
                Estado = true,
                Ejercicios = new List<Ejercicio>()
            },

            new Rutina
            {
                IdRutina = 3,
                Nombre = "Fuerza Avanzada",
                Objetivo = "Fuerza",
                Duracion = 90,
                Nivel = "Avanzado",
                Estado = true,
                Ejercicios = new List<Ejercicio>()
            },

            new Rutina
            {
                IdRutina = 4,
                Nombre = "Cardio Extremo",
                Objetivo = "Resistencia",
                Duracion = 50,
                Nivel = "Intermedio",
                Estado = true,
                Ejercicios = new List<Ejercicio>()
            },

            new Rutina
            {
                IdRutina = 5,
                Nombre = "Tonificación General",
                Objetivo = "Tonificación",
                Duracion = 55,
                Nivel = "Principiante",
                Estado = true,
                Ejercicios = new List<Ejercicio>()
            }
        };

        public List<Rutina> ObtenerRutinas()
        {
            return rutinas;
        }

        public Rutina CrearRutina(Rutina rutina)
        {
            rutina.IdRutina = rutinas.Count + 1;

            if (rutina.Ejercicios == null)
                rutina.Ejercicios = new List<Ejercicio>();

            rutinas.Add(rutina);

            return rutina;
        }
    }
}