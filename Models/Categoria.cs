using GestaoInventarioV3.Models;

public class Categoria
{
    public int CategoriaId { get; set; }
    public string Nome { get; set; } = string.Empty; // Inicializando com string vazia
    public List<Produto> Produtos { get; set; } = new List<Produto>(); // Inicialização direta
}
