using CineGo.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CineGo.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login([FromBody] AuthDto dto)
    {
        // Lógica de autenticação e geração de token JWT
        return Ok(new { token = "token_exemplo" });
    }
}