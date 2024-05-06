﻿// <auto-generated />
using System;
using ClasesDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClasesDatos.Migrations
{
    [DbContext(typeof(ConexionContext))]
    partial class ConexionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClasesDatos.Carrito", b =>
                {
                    b.Property<int>("idCarrito")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCarrito"));

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int>("oClienteidCliente")
                        .HasColumnType("int");

                    b.Property<int>("oProductoidProducto")
                        .HasColumnType("int");

                    b.HasKey("idCarrito");

                    b.HasIndex("oClienteidCliente");

                    b.HasIndex("oProductoidProducto");

                    b.ToTable("Carrito", (string)null);
                });

            modelBuilder.Entity("ClasesDatos.Categoria", b =>
                {
                    b.Property<int>("idCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCategoria"));

                    b.Property<bool>("activo")
                        .HasColumnType("bit");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCategoria");

                    b.ToTable("Categoria", (string)null);
                });

            modelBuilder.Entity("ClasesDatos.Cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCliente"));

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("restablecerContraseña")
                        .HasColumnType("bit");

                    b.HasKey("idCliente");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("ClasesDatos.DetalleVenta", b =>
                {
                    b.Property<int>("idDetalleVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idDetalleVenta"));

                    b.Property<int?>("VentaidVenta")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<string>("idTransaccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idVenta")
                        .HasColumnType("int");

                    b.Property<int>("oProductoidProducto")
                        .HasColumnType("int");

                    b.Property<float>("total")
                        .HasColumnType("real");

                    b.HasKey("idDetalleVenta");

                    b.HasIndex("VentaidVenta");

                    b.HasIndex("oProductoidProducto");

                    b.ToTable("DetalleVenta", (string)null);
                });

            modelBuilder.Entity("ClasesDatos.Marca", b =>
                {
                    b.Property<int>("idMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idMarca"));

                    b.Property<bool>("activo")
                        .HasColumnType("bit");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMarca");

                    b.ToTable("Marca", (string)null);
                });

            modelBuilder.Entity("ClasesDatos.Producto", b =>
                {
                    b.Property<int>("idProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idProducto"));

                    b.Property<bool>("activo")
                        .HasColumnType("bit");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreImagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("oCategoriaidCategoria")
                        .HasColumnType("int");

                    b.Property<int>("oMarcaidMarca")
                        .HasColumnType("int");

                    b.Property<float>("precio")
                        .HasColumnType("real");

                    b.Property<string>("rutaImagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("idProducto");

                    b.HasIndex("oCategoriaidCategoria");

                    b.HasIndex("oMarcaidMarca");

                    b.ToTable("Producto", (string)null);
                });

            modelBuilder.Entity("ClasesDatos.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idUsuario"));

                    b.Property<bool>("activo")
                        .HasColumnType("bit");

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("restablecerContraseña")
                        .HasColumnType("bit");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("ClasesDatos.Venta", b =>
                {
                    b.Property<int>("idVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idVenta"));

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idCliente")
                        .HasColumnType("int");

                    b.Property<string>("idTransaccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("montoTotal")
                        .HasColumnType("real");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("totalCompra")
                        .HasColumnType("int");

                    b.HasKey("idVenta");

                    b.ToTable("Venta", (string)null);
                });

            modelBuilder.Entity("ClasesDatos.Carrito", b =>
                {
                    b.HasOne("ClasesDatos.Cliente", "oCliente")
                        .WithMany()
                        .HasForeignKey("oClienteidCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClasesDatos.Producto", "oProducto")
                        .WithMany()
                        .HasForeignKey("oProductoidProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("oCliente");

                    b.Navigation("oProducto");
                });

            modelBuilder.Entity("ClasesDatos.DetalleVenta", b =>
                {
                    b.HasOne("ClasesDatos.Venta", null)
                        .WithMany("ODetalleVenta")
                        .HasForeignKey("VentaidVenta");

                    b.HasOne("ClasesDatos.Producto", "oProducto")
                        .WithMany()
                        .HasForeignKey("oProductoidProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("oProducto");
                });

            modelBuilder.Entity("ClasesDatos.Producto", b =>
                {
                    b.HasOne("ClasesDatos.Categoria", "oCategoria")
                        .WithMany()
                        .HasForeignKey("oCategoriaidCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClasesDatos.Marca", "oMarca")
                        .WithMany()
                        .HasForeignKey("oMarcaidMarca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("oCategoria");

                    b.Navigation("oMarca");
                });

            modelBuilder.Entity("ClasesDatos.Venta", b =>
                {
                    b.Navigation("ODetalleVenta");
                });
#pragma warning restore 612, 618
        }
    }
}