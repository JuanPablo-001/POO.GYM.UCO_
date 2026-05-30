namespace POO.GYM.Models
{
    public class Usuario : Persona
    {
        public string Objetivo { get; set; }
        public string EstadoFisico { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Relación con entrenador
        public Entrenador? Entrenador { get; set; }

        // Relación con perfil físico
        public PerfilFisico ? PerfilFisico { get; set; }

        // Relación con rutinas
        public List<Rutina> Rutinas { get; set; } = new List<Rutina>();

        // Relación con progreso
        public List<Progreso> Progresos { get; set; } = new List<Progreso>();

        // Relación con estadísticas
        public Estadisticas? Estadisticas { get; set; }
        public int IdUsuario { get; internal set; }
    }
}

