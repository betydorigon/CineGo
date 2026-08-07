using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Application.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int FilmesCount { get; set; }
    }
    public class CategoryCreateDto
    {
        public string Name { get; set; } = string.Empty;
    }

    public class CategoryUpdateDto
    {
        public string Name { get; set; } = string.Empty;
    }
}
