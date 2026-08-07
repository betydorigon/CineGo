using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using CineGo.Application.DTOs;
using CineGo.Application.Interfaces;
using CineGo.domain.Interfaces;
using CineGo.domain.Entities;

namespace CineGo.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoryService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var categories = await _categoriaRepository.GetAllAsync();
            return categories.Select(MapToDto);
        }

        public async Task<CategoryDto?> GetByIdAsync(int id)
        {
            var category = await _categoriaRepository.GetByIdAsync(id);
            return category == null ? null : MapToDto(category);
        }

        public async Task<CategoryDto> CreateAsync(CategoryCreateDto dto)
        {
            var categoria = new Categoria { Name = dto.Name };
            await _categoriaRepository.AddSync(categoria);
            return MapToDto(categoria);
        }

        public async Task<CategoryDto?> UpdateAsync(int id, CategoryUpdateDto dto)
        {
            var categoria = await _categoriaRepository.GetByIdAsync(id);
            if (categoria == null) return null;

            categoria.Name = dto.Name;
            await _categoriaRepository.UpdateSync(categoria);
            return MapToDto(categoria);
        }

        public async Task DeleteAsync(int id)
        {
            var categoria = await _categoriaRepository.GetByIdAsync(id);
            if (categoria == null) return;
            await _categoriaRepository.DeleteSync(id);
        }

        public async Task<int> CountAsync()
        {
            return await _categoriaRepository.CountAsync();
        }

        private static CategoryDto MapToDto(Categoria category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                FilmesCount = category.Filmes?.Count ?? 0
            };
        }
    }
}
