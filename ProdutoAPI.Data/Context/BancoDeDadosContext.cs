using Microsoft.EntityFrameworkCore;
using ProdutoAPI.Domain.Entidades;

namespace ProdutoAPI.Data.Context
{
    public class BancoDeDadosContext : DbContext
    {
        public BancoDeDadosContext(DbContextOptions<BancoDeDadosContext> opcoes)
            : base(opcoes)
        {
        }

        // Aqui vamos declarar as "tabelas" (entidades) em breve:
        // public DbSet<Produto> Produtos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
