using CineGo.Application.DTOs;
using CineGo.domain.Interfaces;
using CineGo.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CineGo.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriasController : ControllerBase
{
    private readonly ICategoriaRepository _categoriaRepository;

    public CategoriasController(ICategoriaRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    [HttpGet]
    public async Task<IActionResult> ObterTodas()
    {
        var categorias = await _categoriaRepository.ObterTodasAsync();
        return Ok(categorias);
    }
}