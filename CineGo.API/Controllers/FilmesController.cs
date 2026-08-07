// =============================================================================
// SenacGames.API - GamesController
// =============================================================================
//  CONCEITO IMPORTANTE: API Controller
// Um API Controller é responsável por receber requisições HTTP
// e retornar respostas em formato JSON.
//
// Diferença entre API Controller e MVC Controller:
// - API Controller: retorna DADOS (JSON) — [ApiController]
// - MVC Controller: retorna VIEWS (HTML) — Controller normal
//
// Endpoints REST deste controller:
// GET    /api/games        Lista todos os games
// GET    /api/games/{id}   Busca um game pelo Id
// POST   /api/games        Cria um novo game
// PUT    /api/games/{id}   Atualiza um game existente
// DELETE /api/games/{id}   Remove um game
// =============================================================================


using CineGo.Application.DTOs;
using CineGo.domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CineGo.API.Controllers;

/// <summary>
/// Controller REST para operações com Games.
/// </summary>

[ApiController]
[Route("api/[controller]")]
public class FilmesController : ControllerBase
{
    private readonly IFilmeService _filmeService;

    //  CONCEITO: O serviço é injetado automaticamente pelo .NET (DI)
    public FilmesController (IFilmeService filmeService)
    {
        _filmeService = filmeService;
    }

    /// <summary>
    /// Retorna todos os games.
    /// GET /api/games
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<FilmeDto>>> GetAll()
    {
        var filmes = await _filmeService.GetAllAsync();
        return Ok(filmes);
    }

    /// <summary>
    /// Busca um game específico pelo Id.
    /// GET /api/games/{id}
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ActionResult<FilmesDto>> GetById(int id)
    {
        var filme = await _filmeService.GetByIdAsync(id);

        if (filme == null)
            return NotFound(new { message = "Filme não encontrado."});

        return Ok(filme);
    }

    /// <summary>
    /// Cria um novo game.
    /// POST /api/games
    /// Requer autenticação (somente admin pode criar games).
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<FilmeDto>> Create([FromBody] CreateFilmesDto dto)
    {
        var filme = await _filmeService.CreateAsync(dto);

        // Retorna 201 Created com a URL do recurso criado
        return CreatedAtAction(nameof(GetById), new { id = filme.Id }, filme);
    }

    /// <summary>
    /// Atualiza um game existente.
    /// PUT /api/games/{id}
    /// </summary>
    [HttpPut("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<FilmesDto>> Update(int id, [FromBody] UpdateGameDto dto)
    {
        var filme = await _filmeService.UpdateAsync(id, dto);

        if (filme == null)
            return NotFound(new { message = "Filme não encontrado." });

        return Ok(filme);
    }

    /// <summary>
    /// Remove um game.
    /// DELETE /api/games/{id}
    /// </summary>
    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult> Delete(int id)
    {
        var deleted = await _filmeService.DeleteAsync(id);

        if (!deleted)
            return NotFound(new { message = "Filme não encontardo." });

        return NoContent(); // Retorna 204 No Content (sucesso sem corpo)
    }
}