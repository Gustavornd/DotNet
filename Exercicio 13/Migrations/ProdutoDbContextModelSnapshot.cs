﻿// <auto-generated />
using Exercicio_13.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exercicio_13.Migrations
{
    [DbContext(typeof(ProdutoDbContext))]
    partial class ProdutoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Exercicio_13.Data.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descr")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<double>("Preço")
                        .HasColumnType("REAL");

                    b.Property<int>("Quant")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            Descr = "Excelente notebook",
                            Nome = "Laptop",
                            Preço = 2000.02,
                            Quant = 10
                        },
                        new
                        {
                            Id = 1002,
                            Descr = "Um MS Office",
                            Nome = "Microsoft Office",
                            Preço = 400.99000000000001,
                            Quant = 50
                        },
                        new
                        {
                            Id = 1003,
                            Descr = "Um mouse que funciona",
                            Nome = "Mouse",
                            Preço = 12.02,
                            Quant = 20
                        },
                        new
                        {
                            Id = 1004,
                            Descr = "Armazene incríveis 256GB de dados",
                            Nome = "HD USB",
                            Preço = 5.0,
                            Quant = 200
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
