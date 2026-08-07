using System.Collections.Generic;
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

        // Retorna todos os filmes incluindo a categoria (FK) para permitir acesso aos dados de Categoria
        public async Task<IEnumerable<Filmes>> ObterTodosAsync()
        {
            return await _context.Filmes
                 .Include(f => f.Categoria)// garante carregamento da FK/navegação
                 .AsNoTracking()
                 .ToListAsync();
        }

        // Retorna um filme por id incluindo a categoria
        public async Task<Filmes?> ObterPorIdAsync(int id)
        {
            return await _context.Filmes
                   .Include(f => f.Categoria)
                   .AsNoTracking()
                   .FirstOrDefaultAsync(f => f.Id == id);
        }

        // Adiciona um novo filme (assume que CategoriaId esteja válido)
        public async Task AdicionarAsync(Filmes filme)
        {
            await _context.Filmes.AddAsync(filme);
            await _context.SaveChangesAsync();
        }

        // Atualiza um filme existente
        public async Task AtualizarAsync(Filmes filme)
        {
            _context.Filmes.Update(filme);
            await _context.SaveChangesAsync();
        }

        // Remove um filme por id
        public async Task DeletarAsync(int id)
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
