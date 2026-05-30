namespace POO.GYM.Models
{

    public class Estadisticas
    {
        public int RutinasCompletadas { get; set; }

        public double CaloriasQuemadas { get; set; }

        public int TiempoEntrenado { get; set; }

        // Relación con usuario
        public Usuario Usuario { get; set; }

        public void MostrarEstadisticas()
        {
            Console.WriteLine("Mostrando estadísticas");
        }
    }
}
    