﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace prestamos.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230125032741_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("Ocupaciones", b =>
                {
                    b.Property<int>("OcupacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Salario")
                        .HasColumnType("REAL");

                    b.HasKey("OcupacionId");

                    b.ToTable("Opcupaciones");
                });
#pragma warning restore 612, 618
        }
    }
}
