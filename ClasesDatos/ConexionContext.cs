using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDatos
{
    public class ConexionContext : DbContext
    {
        public ConexionContext(DbContextOptions<ConexionContext> options) : base(options) { }

        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        // Cambiar los nombres de plural a singular
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carrito>().ToTable("Carrito");
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<DetalleVenta>().ToTable("DetalleVenta");
            modelBuilder.Entity<Marca>().ToTable("Marca");
            modelBuilder.Entity<Producto>().ToTable("Producto");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Venta>().ToTable("Venta");

        }

    }
}
