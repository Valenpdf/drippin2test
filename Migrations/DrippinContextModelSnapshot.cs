﻿// <auto-generated />
using System;
using Drippin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Drippin.Migrations
{
    [DbContext(typeof(DrippinContext))]
    partial class DrippinContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Drippin.Models.Producto", b =>
                {
                    b.Property<int>("proId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("proId"));

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<bool>("EsDestacado")
                        .HasColumnType("bit");

                    b.Property<string>("proImagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("proImagen2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("proImagen3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("proImagen4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("proNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("proPrecio")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("prodCreacion")
                        .HasColumnType("datetime2");

                    b.HasKey("proId");

                    b.ToTable("Producto");
                });
#pragma warning restore 612, 618
        }
    }
}
