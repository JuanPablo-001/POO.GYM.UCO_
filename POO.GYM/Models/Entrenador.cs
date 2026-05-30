using System.Collections.Generic;

namespace POO.GYM.Models
{
    public class Entrenador : Persona
    {
        public int IdEntrenador { get; set; }

        public string Especialidad { get; set; }

        public int Experiencia { get; set; }

        public List<Usuario> Usuarios { get; set; }

        public Entrenador()
        {
            Usuarios = new List<Usuario>();
        }
    }
}