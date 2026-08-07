using CineGo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Application.Interfaces
{
    public interface IFilmeService
    {
        Task<IEnumerable<FilmeDto>> GetAllAsync();
        Task<FilmeDto> GetByIdAsync(int id);
        Task<IEnumerable<FilmeDto>> GetByCategoryIdAsync(int categoryId);
        Task<FilmeDto> CreateAsync(CreateFilmesDto dto);
        Task<FilmeDto> UpdateAsync(int id, UpdateFilmesDto dto);
        Task<bool> DeleteAsync(int id);
        Task<int> CountAsync();
    } 
}
