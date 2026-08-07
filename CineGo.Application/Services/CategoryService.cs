using CineGo.Application.DTOs;
using CineGo.Application.Interfaces;
using CineGo.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoryService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        public async Task<IEnumerable<CategoryDto>> 
    }
}
