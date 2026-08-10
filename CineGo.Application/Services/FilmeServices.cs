using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineGo.Application.DTOs;
using CineGo.Application.Interfaces;
using CineGo.domain;
using CineGo.domain.Entities;

namespace CineGo.Application.Services
{
    public class FilmeServices : IFilmeService
    {
        private readonly IFilmesRepository _filmeRepository;

        public FilmeServices(IFilmesRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        public async Task<IEnumerable<FilmeDto>> GetAllAsync()
        {
            var filmes = await _filmeRepository.GetAllAsync();
            return filmes.Select(MapToDto);
        }

        public async Task<FilmeDto?> GetByIdAsync(int id)
        {
            var filme = await _filmeRepository.GetByIdAsync(id);
            return filme == null ? null : MapToDto(filme);
        }

        public async Task<IEnumerable<FilmeDto>> GetByCategoryIdAsync(int categoryId)
        {
            var filmes = await _filmeRepository.GetByCategoryAsync(categoryId);
            return filmes.Select(MapToDto);
        }

        

        public async Task<FilmeDto> CreateAsync(CreateFilmesDto filmesDto) 
        {
            var filme = new Filmes
            {
                Titulo = filmesDto.Titulo,
                Duracao = filmesDto.Duracao,
                Sinopse = filmesDto.Sinopse,
                RealeseYear = filmesDto.RealeseYear,
                CategoriaId = filmesDto.CategoriaId,
                Classificacao = filmesDto.Classificacao,
                CoverImageUrl = filmesDto.CoverImageUrl
            };

            await _filmeRepository.AddAsync(filme);

            return MapToDto(filme);
        }

        public async Task<FilmeDto> UpdateAsync(int id, UpdateFilmesDto filmesDto)
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

            await _filmeRepository.UpdateASync(filme);
            return MapToDto(filme);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var filme = await _filmeRepository.GetByIdAsync(id);
            if (filme == null) return false;
            await _filmeRepository.DeleteASync(id);
            return true;
        }

        public async Task<int> CountAsync()
        {
            return await _filmeRepository.CountAsync();
        }

        private static FilmeDto MapToDto(Filmes filme)
        {
            return new FilmeDto
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
