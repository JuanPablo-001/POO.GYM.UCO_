using POO.GYM.Models;

namespace POO.GYM.Interfaces
{
    public interface IEntrenadorService
    {
        List<Entrenador> ObtenerEntrenadores();
        Entrenador CrearEntrenador(Entrenador entrenador);
    }
}