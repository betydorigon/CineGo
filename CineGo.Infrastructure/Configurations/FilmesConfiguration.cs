using CineGo.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Infrastructure.Configurations
{
    public class FilmesConfiguration : IEntityTypeConfiguration<Filmes>
    {
        public void Configure(EntityTypeBuilder<Filmes> builder)
        {
            builder.ToTable("Filmes");

            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id)
                .ValueGeneratedOnAdd();

            builder.Property(f => f.Titulo)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(f => f.Sinopse)
                .HasMaxLength(2000);

            builder.Property(f => f.Duracao)
                .HasMaxLength(30);

            builder.Property(f => f.RealeseYear)
                .IsRequired();

            builder.Property(f => f.CoverImageUrl)
                .HasMaxLength(5000)
                .HasColumnName("CoverImageUrl");

            // Chave estrangeira para Categoria
            builder.Property(f => f.CategoriaId)
                .IsRequired()
                .HasColumnName("CategoriaId");

            builder.HasOne(f => f.Categoria)
                .WithMany(c => c.Filmes)
                .HasForeignKey(f => f.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Índice em título para buscas
            builder.HasIndex(f => f.Titulo)
                .HasDatabaseName("IX_Filmes_Titulo");
        }
    }
}
