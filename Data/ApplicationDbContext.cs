using Microsoft.EntityFrameworkCore;
using GestaoInventarioV3.Models;

namespace GestaoInventarioV3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura o tipo da coluna para o preço do produto com precisão específica
            modelBuilder.Entity<Produto>().Property(p => p.Preco).HasColumnType("decimal(18,2)");
        }
    }
}

