using CineGo.domain.Entities;
using CineGo.Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Infrastructure.Context
{
    public class CineGoDbContext : IdentityDbContext
    {
        public CineGoDbContext(DbContextOptions<CineGoDbContext> options) : base(options)
        {
        }

        public DbSet<Filmes> Filmes { get; set; }
        
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new FilmesConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
        }
    }
}
