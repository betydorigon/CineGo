using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Desktop.DTOs
{
    public class CategoriaResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int FilmesCount { get; set; }
    }

    public class CreateCategoriaDto
    {
        public string Name { get; set; } = string.Empty;
    }

    public class UpdateCategoriaDto
    {
        public string Name { get; set; } = string.Empty;
    }
}
