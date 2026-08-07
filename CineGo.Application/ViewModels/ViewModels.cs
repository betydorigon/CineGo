using CineGo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Application.ViewModels
{
    public class HomeViewModel
    {
       public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
       public IEnumerable<FilmeDto> Filmes { get; set; } = new List<FilmeDto>();
    }

    public class FilmesDetailsViewModel
    {
        public FilmeDto Filme { get; set; } = new FilmeDto();
        public IEnumerable<FilmeDto> RelatedFilmes { get; set; } = new List<FilmeDto>();
    }

    public class DashboardViewModel
    {
        public int TotalFilmes { get; set; }
        public int TotalCategorias { get; set; }
        public int TotalUsuarios { get; set; }
        public IEnumerable<FilmeDto> RecentFilmes { get; set; } = new List<FilmeDto>();
    }

    public class FilmeFormViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Sinopse { get; set; } = string.Empty;
        public int RealeseYear { get; set; }
        public int CategoriaId { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;

        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();

    }

    public class  FilmeListViewModel
    {
        public IEnumerable<FilmeDto> Filmes { get; set; } = new List<FilmeDto>();
        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
        public int? SelectedCategoryId { get; set; }
    }
}
