using CineGo.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineGo.Infrastructure.Configurations
{
    public class CategoriesConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categorias");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Name");

            // Relacionamento com Filmes
            builder.HasMany(c => c.Filmes)
                .WithOne(f => f.Categoria)
                .HasForeignKey(f => f.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Índice único por nome (opcional; retire .IsUnique() se não desejar)
            builder.HasIndex(c => c.Name)
                .HasDatabaseName("IX_Categorias_Name")
                .IsUnique();
        }
    }
}
