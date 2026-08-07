using CineGo.Application.DTOs;
using CineGo.domain;
using CineGo.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CineGo.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FilmesController : ControllerBase
{
    private readonly IFilmesRepository _filmesRepository;

    public FilmesController(IFilmesRepository filmesRepository)
    {
        _filmesRepository = filmesRepository;
    }

    [HttpGet]
    public async Task<IActionResult> ObterTodos()
    {
        var filmes = await _filmesRepository.ObterTodosAsync();
        return Ok(filmes);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> ObterPorId(int id)
    {
        var filme = await _filmesRepository.ObterPorIdAsync(id);
        if (filme == null) return NotFound();
        return Ok(filme);
    }

    [HttpPost]
    public async Task<IActionResult> Criar([FromBody] FilmesDto dto)
    {
        // Implementar a criação através do repositório/serviço
        return CreatedAtAction(nameof(ObterPorId), new { id = dto.Id }, dto);
    }
}