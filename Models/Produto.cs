using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoInventarioV3.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
