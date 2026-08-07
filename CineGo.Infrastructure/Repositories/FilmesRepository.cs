using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CineGo.domain;
using CineGo.domain.Entities;
using CineGo.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CineGo.Infrastructure.Repositories
{
    public class FilmesRepository : IFilmesRepository
    {
        private readonly CineGoDbContext _context;

        public FilmesRepository(CineGoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Filmes>> GetAllAsync()
        {
            return await _context.Filmes
                 .Include(f => f.Categoria)
                 .AsNoTracking()
                 .ToListAsync();
        }

        public async Task<Filmes?> GetByIdAsync(int id)
        {
            return await _context.Filmes
                  .Include(f => f.Categoria)
                  .AsNoTracking()
                  .FirstOrDefaultAsync(f => f.Id == id);
        }

        // Retorna os "destaques" — implementado como top 5 por Classificacao desc, RealeseYear desc
        public async Task<IEnumerable<Filmes>> GetFeaturedAsync()
        {
            return await _context.Filmes
               .Include(f => f.Categoria)
               .AsNoTracking()
               .OrderByDescending(f => f.Classificacao)
               .ThenByDescending(f => f.RealeseYear)
               .Take(5)
               .ToListAsync();
        }

        public async Task<IEnumerable<Filmes>> GetByCategoryAsync(int categoryId)
        {
            return await _context.Filmes
                .Include(f => f.Categoria)
                .AsNoTracking()
                .Where(f => f.CategoriaId == categoryId)
                .ToListAsync();
        }


        public async Task AddASync(Filmes filme)
        {
            await _context.Filmes.AddAsync(filme);
            await _context.SaveChangesAsync();
        }

        // Atualiza um filme existente
        public async Task UpdateSync(Filmes filme)
        {
            _context.Filmes.Update(filme);
            await _context.SaveChangesAsync();
        }

        // Remove um filme por id
        public async Task DeleteSync(int id)
        {
            var filme = await _context.Filmes.FindAsync(id);
            if (filme is null) return;

            _context.Filmes.Remove(filme);
            await _context.SaveChangesAsync();
        }

        // Conta filmes
        public async Task<int> CountAsync()
        {
            return await _context.Filmes.CountAsync();
        }
    }
}
