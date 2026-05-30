namespace POO.GYM.Models
{
    public abstract class PlanEntrenamiento
    {
        public string Intensidad { get; set; }
        public int FrecuenciaSemanal { get; set; }

        public List<Rutina> Rutinas { get; set; } = new List<Rutina>();
    }

       
    
}
