using Microsoft.AspNetCore.Mvc;
using POO.GYM.Interfaces;
using POO.GYM.Models;

namespace POO.GYM.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RutinasController : ControllerBase
    {
        private readonly IRutinaService _rutinaService;

        public RutinasController(IRutinaService rutinaService)
        {
            _rutinaService = rutinaService;
        }

        [HttpGet]
        public IActionResult ObtenerRutinas()
        {
            return Ok(_rutinaService.ObtenerRutinas());
        }

        [HttpPost]
        public IActionResult CrearRutina([FromBody] Rutina rutina)
        {
            try
            {
                if (rutina == null)
                    return BadRequest();

                if (string.IsNullOrWhiteSpace(rutina.Nombre))
                    return BadRequest("El nombre es obligatorio");

                var nueva = _rutinaService.CrearRutina(rutina);

                return StatusCode(201, nueva);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}