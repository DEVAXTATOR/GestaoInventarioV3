using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoInventarioV3.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        // Chave estrangeira para Categoria
        public int CategoriaId { get; set; }

        // Propriedade de navegação para Categoria
        public Categoria Categoria { get; set; }
    }
}
