using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.domain.Entities
{
    public class Filmes
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Duracao { get; set; } = string.Empty;
        public string Sinopse { get; set; } = string.Empty;
        public int RealeseYear { get; set; }
        public string CategoriaId { get; set; }
        public int Classificacao { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;

        public virtual Categoria? Categoria { get; set; }
    }
}
