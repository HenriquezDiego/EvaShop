using EvaShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace EvaShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<Descuento> Descuentos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<WishList> WishList { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Articulo>().Property(a => a.Id).HasDefaultValueSql("NEWID()");
            builder.Entity<Detalle>().Property(d=>d.PrecioUnitario).HasColumnType("decimal(18, 5)");
            builder.Entity<Detalle>().Property(d=>d.Descuento).HasColumnType("decimal(18, 5)");
            builder.Entity<Pedido>().Property(d=>d.TotalVenta).HasColumnType("decimal(18, 5)");
            builder.Entity<Inventario>()
                .Property(d=>d.PrecioDeVenta).HasColumnType("decimal(18, 5)");
            builder.Entity<Inventario>()
                .Property(d=>d.Costo).HasColumnType("decimal(18, 5)");
            builder.Entity<Descuento>().Property(d=>d.Valor).HasColumnType("decimal(18, 5)");
            builder.Entity<Estado>().Property(t => t.Id).HasConversion<int>();
            builder.Entity<Articulo>().Property(a => a.CodigoDeBarra).HasDefaultValue("");
            builder.Entity<Categoria>().HasData(DataSeeder.Categorias);
            builder.Entity<SubCategoria>().HasData(DataSeeder.SubCategorias);
            builder.Entity<Articulo>().HasData(DataSeeder.Articulos);
            builder.Entity<Inventario>().HasData(DataSeeder.Inventarios);
            base.OnModelCreating(builder);
        }
    }
}