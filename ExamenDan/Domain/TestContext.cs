using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ExamenDan.Domain
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Sucursal> Sucursals { get; set; }

     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasKey(x => new { x.ProductoId, x.SucursalId });
                entity.HasOne(x => x.Producto);
                entity.HasOne(x => x.Sucursal);
                

            });

            modelBuilder.Entity<Producto>(entity =>
            {
                

                entity.Property(e => e.CodigoBarra).HasColumnName("Codigo_Barra");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

            

                entity.Property(e => e.PrecioUnitario)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("Precio_Unitario");
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                

                entity.ToTable("Sucursal");

              

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
