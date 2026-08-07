using CineGo.domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.domain.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> GetAllAsync();
        Task<Categoria?> GetByIdAsync(int id);
        Task AddSync(Categoria categoria);
        Task UpdateSync(Categoria categoria);
        Task DeleteSync(int id);
        Task<int> CountAsync();
    }
}
