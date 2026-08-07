using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using CineGo.Application.DTOs;
using CineGo.Application.Interfaces;
using CineGo.domain.Entities;
using CineGo.domain.Interfaces;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CineGo.Application.Services
{
    public class FilmeServices : IFilmeService
    {
        private readonly IFilmeService _filmeRepository;
        public FilmeServices(IFilmeService filmeService)
        {
            _filmeRepository = filmeService;
        }
        public async Task<IEnumerable<FilmesDto>> GetAllSync()
        {
            var filme = await _filmeRepository.GetAllSync();
            return filme.Select(MapToDto);

        }

        public async Task<FilmesDto?> GetByIdAsync(int id)
        {
            var filme = await _filmeRepository.GetByIdAsync(id);
            return filme == null ? null : MapToDto(filme);
        }

        public async Task<IEnumerable<FilmesDto>> GetByCategoryAsync(int categoryId)
        {
            var filmes = await _filmeRepository.GetByCategoryIdAsync(categoryId);
            return filmes.Select(MapToDto);
        }

        public async Task<FilmesDto> CreateAsync(CreateFilmesDto filmesDto) 
        {
            var filme = new filme
            {
                name = filmesDto.Titulo,
                duration = filmesDto.Duracao,
                sinopse = filmesDto.Sinopse,
                year = filmesDto.RealeseYear,
                categoriaID = filmesDto.CategoriaId,
                Classificacao = filmesDto.Classificacao,
                CoverImageUrl = filmesDto.CoverImageUrl
            };

            await _filmeRepository.AddAsync(filme);

            return MapToDto(filme);
        
        }

        public async Task<FilmesDto> UpdateAsync(int id, UpdateFilmesDto filmesDto)
        {
            var filme = await _filmeRepository.GetByIdAsync(id);
            if (filme == null) return null;

            filme.Titulo = filmesDto.Titulo;
            filme.Duracao = filmesDto.Duracao;
            filme.Sinopse = filmesDto.Sinopse;
            filme.RealeseYear = filmesDto.RealeseYear;
            filme.CategoriaId = filmesDto.CategoriaId;
            filme.Classificacao = filmesDto.Classificacao;
            filme.CoverImageUrl = filmesDto.CoverImageUrl;

            await _filmeRepository.UpdateAsync(filme);
            return MapToDto(filme);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var filme = await _filmeRepository.GetByIdAsync(id);
            if (filme == null) return false;
            await _filmeRepository.DeleteAsync(id);
            return true;
        }

        public async Task<int> CountAsync()
        {
            return await _filmeRepository.CountAsync();
        }

        private static FilmesDto MapToDto(Filmes filme)
        {
            return new FilmesDto
            {
                Id = filme.Id,
                Titulo = filme.Titulo,
                Duracao = filme.Duracao,
                Sinopse = filme.Sinopse,
                RealeseYear = filme.RealeseYear,
                CategoriaId = filme.CategoriaId,
                Classificacao = filme.Classificacao,
                CoverImageUrl = filme.CoverImageUrl
            };
        }
    }
}
