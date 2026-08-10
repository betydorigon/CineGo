// =============================================================================
// ineGo.Desktop - Services/FilmesApiService.cs
// =============================================================================
//  CONCEITO: Service de Games
//
// Realiza todas as operações CRUD de filmes via API REST:
//   GET    /api/filmes         Listar todos os filmes
//   GET    /api/filmes/{id}    Buscar filme por ID
//   POST   /api/filmes         Criar filme (requer Admin)
//   PUT    /api/filmes/{id}    Atualizar filme (requer Admin)
//   DELETE /api/filmes/{id}    Excluir filme (requer Admin)
//
// IMPORTANTE: As operações de escrita (POST, PUT, DELETE) requerem
// que o usuário esteja autenticado como Admin.
// A autorização é verificada pela própria API, não pelo Desktop.
// O Desktop não precisa verificar roles para fazer a chamada —
// mas deve controlar a INTERFACE (exibir/ocultar botões) baseado no perfil.
// =============================================================================

using CineGo.Desktop.DTOs;
using CineGo.Desktop.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Desktop.Services
{
    public class FilmesApiService
    {
        private readonly HttpClientHelper _http;

        //Construtor - Inicializa junto com o código quando o mesmo é chamado.
        public FilmesApiService()
        {
            _http = HttpClientHelper.Instance;
        }

        ///<summary>
        /// Lista todas os games via GET /api/games
        /// </summary>
        public async Task<List<FilmeResponseDto>> GetAllAsync()
        {
            try
            {
                var games = await _http.GetAsync<List<FilmeResponseDto>>("/api/filmes");
                return games ?? new List<FilmeResponseDto>();
            }
            catch
            {
                return new List<FilmeResponseDto>();
            }
        }

        /// <summary>
        /// Busca um game específico por ID via GET /api/filmes/{id} 
        /// </summary>
        public async Task<FilmeResponseDto> GetByIdAsync(int id)
        {
            return await _http.GetAsync<FilmeResponseDto>($"/api/filmes/{id}");
        }

        /// <summary>
        /// Cria um novo game via POST /api/filmes.
        /// Requer perfil Admin (verificado pela API).
        /// </summary>
        /// <param name="dto">Dados do filme a ser criado</param>
        /// <returns>Game criado ou null em caso de erro</returns>
        public async Task<(bool Success, FilmeResponseDto? Game, string ErrorMessage)>
            CreateAsync(CreateGameDto dto)
        {
            return await _http.PostAsync<FilmeResponseDto>("/api/filmes", dto);
        }

        /// <summary>
        /// Atualiza um game existente via PUT /api/filmes/{id}.
        /// Requer perfil Admin (verificado pela API).
        /// </summary>
        public async Task<(bool Success, FilmeResponseDto? Game, string ErrorMessage)>
            UpdateAsync(int id, UpdateGameDto dto)
        {
            return await _http.PutAsync<FilmeResponseDto>($"/api/filmes/{id}", dto);
        }

        /// <summary>
        /// Exclui um game via DELETE /api/filmes/{id}.
        /// Requer perfil Admin (verificado pela API).
        /// </summary>
        public async Task<(bool Success, string ErrorMessage)> DeleteAsync(int id)
        {
            return await _http.DeleteAsync($"/api/filmes/{id}");
        }
    }
}
