using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Desktop.DTOs
{
    public  class FilmeResponseDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Duracao { get; set; } = string.Empty;
        public string Sinopse { get; set; } = string.Empty;
        public int RealeseYear { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public int Classificacao { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CategoryName { get; set; } = string.Empty;
        
        public bool IsFeatured { get; set; }

    }

    public class CreateGameDto
    {
        public string Name { get; set; } = string.Empty;
        public string Duracao { get; set; } = string.Empty;
        public string Sinopse { get; set; } = string.Empty;
        public int RealeseYear { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public int Classificacao { get; set; }
        public bool IsFeatured { get; set; }
    }

    public class UpdateGameDto
    {
        public string Name { get; set; } = string.Empty;
        public string Duracao { get; set; } = string.Empty;
        public string Sinopse { get; set; } = string.Empty;
        public int RealeseYear { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public int Classificacao { get; set; }
        public bool IsFeatured { get; set; }
    }
}
