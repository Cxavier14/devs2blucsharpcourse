using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models
{
    public class ContextoDatabase : DbContext
    {
        public ContextoDatabase(DbContextOptions<ContextoDatabase> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // mapeamento de relacionamento
            modelBuilder.Entity<Produto>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaId);

            // seed
            modelBuilder.Entity<Categoria>()
                .HasData(
                new { Id = 1, Nome = "Alimentos Perecíveis" },
                new { Id = 2, Nome = "Laticínios" },
                new { Id = 3, Nome = "Limpeza" },
                new { Id = 4, Nome = "Bebidas não Alcoólicas" }
                );
            
            modelBuilder.Entity<Produto>()
                .HasData(
                new { Id = 1, Nome = "Arroz Fumacense", Preco = 14.00, Quantidade = 5, CategoriaId = 1 },
                new { Id = 2, Nome = "Feijão Fumacense", Preco = 12.00, Quantidade = 5, CategoriaId = 1 },
                new { Id = 3, Nome = "Queijo", Preco = 20.00, Quantidade = 5, CategoriaId = 2 },
                new { Id = 4, Nome = "Iogurte", Preco = 15.00, Quantidade = 5, CategoriaId = 2 },
                new { Id = 5, Nome = "Sabão Líquido", Preco = 28.00, Quantidade = 5, CategoriaId = 3 },
                new { Id = 6, Nome = "Multiuso", Preco = 18.00, Quantidade = 5, CategoriaId = 3 },
                new { Id = 7, Nome = "Suco Suq", Preco = 6.00, Quantidade = 5, CategoriaId = 4 },
                new { Id = 8, Nome = "Coca-cola 2L", Preco = 10.00, Quantidade = 5, CategoriaId = 4 }
                );


            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        #endregion
    }
}
