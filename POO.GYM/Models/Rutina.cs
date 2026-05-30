namespace POO.GYM.Models
{
    public class Rutina
    {
        public int IdRutina { get; set; }

        public string Nombre { get; set; }

        public string Objetivo { get; set; }

        public int Duracion { get; set; }

        
        public bool Estado { get; set; }

        
        public string Nivel { get; set; }

        // Relación con usuario
        public Usuario?   Usuario { get; set; }

        // Relación con plan
        public PlanEntrenamiento? PlanEntrenamiento { get; set; }

        // Relación con ejercicios
        public List<Ejercicio> Ejercicios { get; set; }

        public Rutina()
        {
            Ejercicios = new List<Ejercicio>();
        }
    }
}

