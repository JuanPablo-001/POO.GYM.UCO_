using Microsoft.AspNetCore.Mvc;
using POO.GYM.Interfaces;
using POO.GYM.Models;

namespace POO.GYM.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministradoresController : ControllerBase
    {
        private readonly IAdministradorService _administradorService;

        public AdministradoresController(IAdministradorService administradorService)
        {
            _administradorService = administradorService;
        }

        [HttpGet]
        public IActionResult ObtenerAdministradores()
        {
            return Ok(_administradorService.ObtenerAdministradores());
        }

        [HttpPost]
        public IActionResult CrearAdministrador([FromBody] Administrador administrador)
        {
            try
            {
                if (administrador == null)
                    return BadRequest();

                if (string.IsNullOrWhiteSpace(administrador.Nombre))
                    return BadRequest("El nombre es obligatorio");

                var nuevo = _administradorService.CrearAdministrador(administrador);

                return StatusCode(201, nuevo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}