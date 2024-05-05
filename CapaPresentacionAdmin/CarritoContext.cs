using Microsoft.EntityFrameworkCore;
using CapaEntidad;


namespace CapaPresentacionAdmin
{
    public class CarritoContext : DbContext
    {
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Producto> Productos  { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        public CarritoContext(DbContextOptions<CarritoContext> options) : base(options)
        {
        }
    }
}
