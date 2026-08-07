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
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Titulo)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(f => f.Sinopse)
                .HasMaxLength(2000);

            builder.Property(f => f.Duracao)
                .HasMaxLength(30);

            builder.Property(f => f.RealeseYear)
                .IsRequired();
        }
    }
}
