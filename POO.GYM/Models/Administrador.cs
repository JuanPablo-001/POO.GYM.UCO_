
  

namespace POO.GYM.Models
{
       public class Administrador : Persona
        {
            public int IdAdministrador { get; set; }

            // Relación con usuarios
            public List<Usuario> Usuarios { get; set; }

            // Relación con entrenadores
            public List<Entrenador> Entrenadores { get; set; }

            public Administrador()
            {
                Usuarios = new List<Usuario>();
                Entrenadores = new List<Entrenador>();
            }

            public void GestionarUsuarios()
            {
                Console.WriteLine("Gestionando usuarios");
            }

            public void GestionarEntrenadores()
            {
                Console.WriteLine("Gestionando entrenadores");
            }
        }
}


