namespace POO.GYM.Models
{
    public abstract class Ejercicio
    {
       
        
            public int IdEjercicio { get; set; }
            public string? Nombre { get; set; }
            public string? GrupoMuscular { get; set; }
            public string? Dificultad { get; set; }

            // Relación con rutina
            public Rutina? Rutina { get; set; }
        
    }
}
