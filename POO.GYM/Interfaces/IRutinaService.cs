using POO.GYM.Models;

namespace POO.GYM.Interfaces
{
    public interface IRutinaService
    {
        List<Rutina> ObtenerRutinas();
        Rutina CrearRutina(Rutina rutina);
    }
}