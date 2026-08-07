using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.domain.Entities
{
  public class Categoria
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Filmes> Filmes { get; set; } = new List<Filmes>();
    }
}
