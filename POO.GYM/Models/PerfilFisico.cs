namespace POO.GYM.Models
{
    public class PerfilFisico
    {
        public int IdPerfil { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public double MedidasCorporales { get; set; }
        public float MasaCorporal { get; set; }
        public float imc { get; set; }
        public string CondicionFisica { get; set; }
        public int Edad { get; set; }
        // Relación con usuario
        public Usuario Usuario { get; set; }
    }
}
