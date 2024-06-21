﻿// <auto-generated />
using System;
using ExemploEntityFrameworkMySql.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExemploEntityFrameworkMySql.Infra.Migrations
{
    [DbContext(typeof(ExemploEntityFrameworkMySqlContext))]
    partial class ExemploEntityFrameworkMySqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ExemploEntityFrameworkMySql.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime")
                        .HasColumnName("data_alteracao");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime")
                        .HasColumnName("data_cadastro");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("tb_clientes", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
