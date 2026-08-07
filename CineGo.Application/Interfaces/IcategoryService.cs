using CineGo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Application.Interfaces
{
    public interface IcategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllAsync();
        Task<CategoryDto?> GetByIdAsync(int id);
        Task<CategoryDto> CreateAsync(CategoryCreateDto dto);
        Task<CategoryDto?> UpdateAsync(int id, CategoryUpdateDto dto);
        Task DeleteAsync(int id);
        Task<int> CountAsync();
    }
}
