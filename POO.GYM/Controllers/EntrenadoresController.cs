using Microsoft.AspNetCore.Mvc;
using POO.GYM.Interfaces;
using POO.GYM.Models;

namespace POO.GYM.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntrenadoresController : ControllerBase
    {
        private readonly IEntrenadorService _entrenadorService;

        public EntrenadoresController(IEntrenadorService entrenadorService)
        {
            _entrenadorService = entrenadorService;
        }

        [HttpGet]
        public IActionResult ObtenerEntrenadores()
        {
            return Ok(_entrenadorService.ObtenerEntrenadores());
        }

        [HttpPost]
        public IActionResult CrearEntrenador([FromBody] Entrenador entrenador)
        {
            try
            {
                if (entrenador == null)
                    return BadRequest();

                if (string.IsNullOrWhiteSpace(entrenador.Nombre))
                    return BadRequest("El nombre es obligatorio");

                var nuevo = _entrenadorService.CrearEntrenador(entrenador);

                return StatusCode(201, nuevo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}