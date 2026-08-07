using System.Collections.Generic;
using System.Threading.Tasks;
using CineGo.domain.Entities;
using CineGo.domain.Interfaces;
using CineGo.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CineGo.Infrastructure.Repositories
{
    public class CategoriesRepository : ICategoriaRepository
    {
        private readonly CineGoDbContext _context;

        public CategoriesRepository(CineGoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            return await _context.Categorias
                    .Include(c => c.Filmes)
                    .AsNoTracking()
                    .ToListAsync();
        }

        public async Task<Categoria?> GetByIdAsync(int id)
        {
            return await _context.Categorias
                     .Include (c => c.Filmes)
                     .AsNoTracking()
                     .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddSync(Categoria categoria)
        {
            await _context.Categorias.AddAsync(categoria);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSync(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSync(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);
            if (categoria is null) return;

            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();
        }

        public async Task<int> CountAsync()
        {
            return await _context.Categorias.CountAsync();
        }
    }
}
