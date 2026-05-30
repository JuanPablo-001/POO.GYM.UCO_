namespace POO.GYM.Models
{
    public class Progreso
    {
      
            public int IdProgreso { get; set; }
            public DateTime Fecha { get; set; }
            public double PesoLevantado { get; set; }
            public int TiempoEntrenado { get; set; }

            // Relación con usuario
            public Usuario Usuario { get; set; }
        
    }
}
