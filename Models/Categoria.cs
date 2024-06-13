using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestaoInventarioV3.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        // Relação um-para-muitos com Produto
        public List<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
