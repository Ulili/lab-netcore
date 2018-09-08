using Lab4.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Data
{
    public class DadosContext : DbContext
    {
        public DadosContext(DbContextOptions<DadosContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        
    }
}