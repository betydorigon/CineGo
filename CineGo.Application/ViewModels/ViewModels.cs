using CineGo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Application.ViewModels
{
    public class HomeViewModel
    {
       public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
       public IEnumerable<FilmesDto> Filmes { get; set; } = new List<FilmesDto>();
    }

    public class FilmesDetailsViewModel
    {
        public FilmesDto Filme { get; set; } = new FilmesDto();
        public IEnumerable<FilmesDto> RelatedFilmes { get; set; } = new List<FilmesDto>();
    }

    public class DashboardViewModel
    {
        public int TotalFilmes { get; set; }
        public int TotalCategorias { get; set; }
        public int TotalUsuarios { get; set; }
        public IEnumerable<FilmesDto> RecentFilmes { get; set; } = new List<FilmesDto>();
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
        public IEnumerable<FilmesDto> Filmes { get; set; } = new List<FilmesDto>();
        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
        public int? SelectedCategoryId { get; set; }
    }
}
