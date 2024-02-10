using Microsoft.EntityFrameworkCore;
using MyConnect.Entities;

namespace MyConnect.Context
{
    public class MyAppContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source = localhost; Initial Catalog = MyDbTeste; Integrated Security = True; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb
            .Entity<Cliente>()
            .HasKey(x => x.Id)
            .HasName("PK_Clientes");

            mb
            .Entity<Cliente>()
            .HasMany(x => x.Pedidos)
            .WithOne(x => x.Cliente)
            .HasConstraintName("FK_Cliente_Pedidos")
            .HasForeignKey(x => x.ClienteId)
            .OnDelete(DeleteBehavior.Restrict);

            mb
            .Entity<Pedido>()
            .HasKey(x => x.Id)
            .HasName("PK_Pedidos");

            mb
            .Entity<Pedido>()
            .HasMany(x => x.Produtos)
            .WithOne(x => x.Pedido)
            .HasConstraintName("FK_Pedido_Produtos")
            .HasForeignKey(x => x.PedidoId)
            .OnDelete(DeleteBehavior.Restrict);

            mb
            .Entity<Produto>()
            .HasKey(x => x.Id)
            .HasName("PK_Produto");
        }
    }
}