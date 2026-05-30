using POO.GYM.Models;

namespace POO.GYM.Interfaces
{
    public interface IEjercicioService
    {
        List<Fuerza> ObtenerEjercicios();
        Fuerza CrearEjercicio(Fuerza ejercicio);
    }
}