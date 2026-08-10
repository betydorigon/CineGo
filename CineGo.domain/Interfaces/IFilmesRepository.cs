using CineGo.domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.domain
{
    public interface IFilmesRepository
    {
        Task<IEnumerable<Filmes>> GetAllAsync();
        Task<Filmes?> GetByIdAsync(int id);
        Task<IEnumerable<Filmes>> GetFeaturedAsync();
        Task<IEnumerable<Filmes>> GetByCategoryAsync(int categoryId);
        Task AddAsync(Filmes filme);
        Task UpdateAsync(Filmes filme);
        Task DeleteAsync(int id);
        Task<int> CountAsync();



    }
}
