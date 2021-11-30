﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Taller_Heladio.api.Modelos;

namespace Taller_Heladio.api.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211125174235_EntradaDetalle")]
    partial class EntradaDetalle
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Taller_Heladio.api.Modelos.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Correo")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.Color", b =>
                {
                    b.Property<int>("IdColor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdColor");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.Entrada", b =>
                {
                    b.Property<int>("IdEntrada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<int>("Estatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdProveedor")
                        .HasColumnType("int");

                    b.HasKey("IdEntrada");

                    b.HasIndex("IdProveedor");

                    b.ToTable("Entrada");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.EntradaDetalle", b =>
                {
                    b.Property<int>("IdEntradaDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<double>("Cantidad")
                        .HasColumnType("float");

                    b.Property<int?>("IdEntrada")
                        .HasColumnType("int");

                    b.Property<int?>("IdRefaccion")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdEntradaDetalle");

                    b.HasIndex("IdEntrada");

                    b.HasIndex("IdRefaccion");

                    b.ToTable("EntradaDetalle");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.Marca", b =>
                {
                    b.Property<int>("IdMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<int>("Nombre")
                        .HasColumnType("int");

                    b.HasKey("IdMarca");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.Proveedor", b =>
                {
                    b.Property<int>("IdProveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<string>("RFC")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("IdProveedor");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.Refaccion", b =>
                {
                    b.Property<int>("IdRefaccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<double>("Existencia")
                        .HasColumnType("float");

                    b.Property<int?>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdRefaccion");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Refaccion");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.Servicios", b =>
                {
                    b.Property<int>("IdServicios")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TipoServicio")
                        .HasColumnType("int");

                    b.HasKey("IdServicios");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.Vehiculo", b =>
                {
                    b.Property<int>("IdVehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdColor")
                        .HasColumnType("int");

                    b.Property<int>("IdMarca")
                        .HasColumnType("int");

                    b.Property<double>("Kilometraje")
                        .HasColumnType("float");

                    b.Property<string>("Placas")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("IdVehiculo");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdColor");

                    b.HasIndex("IdMarca");

                    b.ToTable("Vehiculo");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.Entrada", b =>
                {
                    b.HasOne("Taller_Heladio.api.Modelos.Proveedor", "Proveedor")
                        .WithMany()
                        .HasForeignKey("IdProveedor");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.EntradaDetalle", b =>
                {
                    b.HasOne("Taller_Heladio.api.Modelos.Entrada", "Entrada")
                        .WithMany()
                        .HasForeignKey("IdEntrada");

                    b.HasOne("Taller_Heladio.api.Modelos.Refaccion", "Refaccion")
                        .WithMany()
                        .HasForeignKey("IdRefaccion");

                    b.Navigation("Entrada");

                    b.Navigation("Refaccion");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.Refaccion", b =>
                {
                    b.HasOne("Taller_Heladio.api.Modelos.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("IdCategoria");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.Vehiculo", b =>
                {
                    b.HasOne("Taller_Heladio.api.Modelos.Cliente", "Cliente")
                        .WithMany("Vehiculo")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Taller_Heladio.api.Modelos.Color", "Color")
                        .WithMany("Vehiculo")
                        .HasForeignKey("IdColor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Taller_Heladio.api.Modelos.Marca", "Marca")
                        .WithMany("Vehiculo")
                        .HasForeignKey("IdMarca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Color");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.Cliente", b =>
                {
                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.Color", b =>
                {
                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("Taller_Heladio.api.Modelos.Marca", b =>
                {
                    b.Navigation("Vehiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
