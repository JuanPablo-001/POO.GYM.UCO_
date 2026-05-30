using POO.GYM.Interfaces;
using POO.GYM.Models;

namespace POO.GYM.Services
{
    public class EjercicioService : IEjercicioService
    {
        private static List<Fuerza> ejercicios = new()
        {
            new Fuerza
            {
                IdEjercicio = 1,
                Nombre = "Press de banca",
                GrupoMuscular = "Pecho",
                Dificultad = "Intermedio",
                PesoMaximo = 100
            },

            new Fuerza
            {
                IdEjercicio = 2,
                Nombre = "Sentadilla",
                GrupoMuscular = "Piernas",
                Dificultad = "Avanzado",
                PesoMaximo = 140
            },

            new Fuerza
            {
                IdEjercicio = 3,
                Nombre = "Peso muerto",
                GrupoMuscular = "Espalda",
                Dificultad = "Avanzado",
                PesoMaximo = 160
            },

            new Fuerza
            {
                IdEjercicio = 4,
                Nombre = "Curl de bíceps",
                GrupoMuscular = "Bíceps",
                Dificultad = "Principiante",
                PesoMaximo = 25
            },

            new Fuerza
            {
                IdEjercicio = 5,
                Nombre = "Press militar",
                GrupoMuscular = "Hombros",
                Dificultad = "Intermedio",
                PesoMaximo = 60
            },

            new Fuerza
            {
                IdEjercicio = 6,
                Nombre = "Dominadas",
                GrupoMuscular = "Espalda",
                Dificultad = "Intermedio",
                PesoMaximo = 0
            },

            new Fuerza
            {
                IdEjercicio = 7,
                Nombre = "Fondos en paralelas",
                GrupoMuscular = "Tríceps",
                Dificultad = "Intermedio",
                PesoMaximo = 0
            },

            new Fuerza
            {
                IdEjercicio = 8,
                Nombre = "Prensa de piernas",
                GrupoMuscular = "Piernas",
                Dificultad = "Avanzado",
                PesoMaximo = 200
            }
        };

        public List<Fuerza> ObtenerEjercicios()
        {
            return ejercicios;
        }

        public Fuerza CrearEjercicio(Fuerza ejercicio)
        {
            ejercicio.IdEjercicio = ejercicios.Count + 1;

            ejercicios.Add(ejercicio);

            return ejercicio;
        }
    }
}