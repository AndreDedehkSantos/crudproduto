﻿// <auto-generated />
using CrudProduto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudProduto.Migrations
{
    [DbContext(typeof(CrudProdutoContext))]
    [Migration("20200628211150_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CrudProduto.Models.AcessorioBasico", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("descricao");

                    b.Property<string>("nome");

                    b.Property<int>("quantidade");

                    b.HasKey("id");

                    b.ToTable("AcessorioBasico");
                });
#pragma warning restore 612, 618
        }
    }
}