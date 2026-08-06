using CineGo.domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.domain
{
    public class IFilmesRepository
    {
        Task<IEnumerable<Filmes>> GetAllAsync();
        Task<Filmes?> GetByIdAsync(int id);
        Task<IEnumerable<Filmes>> GetFeaturedAsync();
        Task<IEnumerable<Filmes>> GetByCategoryAsync(int categoryId);
        Task AddSync(Filmes filme);
        Task UpdateSync(Filmes filme);
        Task DeleteSync(int id);
        Task<int> CountAsync();



    }
}
