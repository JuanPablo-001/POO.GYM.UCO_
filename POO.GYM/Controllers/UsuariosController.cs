using Microsoft.AspNetCore.Mvc;
using POO.GYM.Interfaces;
using POO.GYM.Models;

namespace POO.GYM.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public IActionResult ObtenerUsuarios()
        {
            var usuarios = _usuarioService.ObtenerUsuarios();
            return Ok(usuarios);
        }

        [HttpPost]
        public IActionResult CrearUsuario([FromBody] Usuario usuario)
        {
            try
            {
                if (usuario == null)
                    return BadRequest("El usuario es obligatorio.");

                if (string.IsNullOrWhiteSpace(usuario.Nombre))
                    return BadRequest("El nombre es obligatorio.");

                if (string.IsNullOrWhiteSpace(usuario.Correo))
                    return BadRequest("El correo es obligatorio.");

                var nuevoUsuario = _usuarioService.CrearUsuario(usuario);

                return StatusCode(201, nuevoUsuario);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }


        }
    }
}