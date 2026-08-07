// =============================================================================
// CineGo.API - UsuariosController.cs
// =============================================================================

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CineGo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Requer autenticação por padrão
    public class UsuariosController : Controller
    {
        private readonly IUsuariosService _usuariosService;

        public UsuariosController(IUsuariosService usuariosService)
        {
            _usuariosService = usuariosService;
        }

        /// <summary>
        /// Retorna a lista de todos os usuários.
        /// GET /api/usuarios
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> GetAll()
        { 
            var usuarios = await _usuariosService.GetAllAsync();
            return Ok(usuarios);
        }

        /// <summary>
        /// Retorna um usuário específico pelo ID.
        /// GET /api/usuarios/{id}
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<>>
    }
}
