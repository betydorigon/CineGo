using CineGo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Application.Interfaces
{
    public interface IFilmeService
    {
        Task<IEnumerable<FilmesDto>> GetAllSync();
        Task<FilmesDto> GetByIdAsync(int id);
        Task<IEnumerable<FilmesDto>> GetByCategoryIdAsync(int categoryId);
        Task<FilmesDto> CreateAsync(CreateFilmesDto dto);
        Task<FilmesDto> UpdateAsync(int id, UpdateFilmesDto dto);
        Task<bool> DeleteAsync(int id);
        Task<int> CountAsync();
    } 
}
