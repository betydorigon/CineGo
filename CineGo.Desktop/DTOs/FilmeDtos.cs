using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

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

        [JsonPropertyName("categoryName")]
        public string CategoryName { get; set; } = string.Empty;
        
        public bool IsFeatured { get; set; }

    }

    public class CreateFilmeDto
    {
        public string Titulo { get; set; } = string.Empty;
        public string Duracao { get; set; } = string.Empty;
        public string Sinopse { get; set; } = string.Empty;
        public int RealeseYear { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "CategoriaId deve ser maior que zero.")]
        public int? CategoriaId { get; set; }
        public int Classificacao { get; set; }
        public bool IsFeatured { get; set; }
    }

    public class UpdateFilmeDto
    {
        public string Titulo { get; set; } = string.Empty;
        public string Duracao { get; set; } = string.Empty;
        public string Sinopse { get; set; } = string.Empty;
        public int RealeseYear { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public int Classificacao { get; set; }
        public bool IsFeatured { get; set; }
    }
}
