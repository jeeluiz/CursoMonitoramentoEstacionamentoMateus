﻿// <auto-generated />
using System;
using Curso.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Curso.Infra.Migrations
{
    [DbContext(typeof(AppMonitoramentoContext))]
    partial class AppMonitoramentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Curso.Domain.Models.EstacionamentoModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Capacidade")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(7)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Lougradouro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.HasKey("Id");

                    b.ToTable("Estacionamento");
                });
#pragma warning restore 612, 618
        }
    }
}
