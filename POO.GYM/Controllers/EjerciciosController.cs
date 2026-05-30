using Microsoft.AspNetCore.Mvc;
using POO.GYM.Interfaces;
using POO.GYM.Models;

namespace POO.GYM.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EjerciciosController : ControllerBase
    {
        private readonly IEjercicioService _ejercicioService;

        public EjerciciosController(IEjercicioService ejercicioService)
        {
            _ejercicioService = ejercicioService;
        }

        [HttpGet]
        public IActionResult ObtenerEjercicios()
        {
            return Ok(_ejercicioService.ObtenerEjercicios());
        }

        [HttpPost]
        public IActionResult CrearEjercicio([FromBody] Fuerza ejercicio)
        {
            try
            {
                if (ejercicio == null)
                    return BadRequest();

                if (string.IsNullOrWhiteSpace(ejercicio.Nombre))
                    return BadRequest("El nombre es obligatorio");

                var nuevo = _ejercicioService.CrearEjercicio(ejercicio);

                return StatusCode(201, nuevo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}