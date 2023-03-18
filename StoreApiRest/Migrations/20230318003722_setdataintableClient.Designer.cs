﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StoreApiRest.Datos;

#nullable disable

namespace StoreApiRest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230318003722_setdataintableClient")]
    partial class setdataintableClient
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StoreApiRest.Models.Client", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Edad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Correo = "alexmerino67@gmail.com",
                            Edad = "39",
                            Nombre = "Alexander Merino"
                        },
                        new
                        {
                            Id = "2",
                            Correo = "mariaemilia@gmail.com",
                            Edad = "3",
                            Nombre = "Maria Emilia Merino"
                        },
                        new
                        {
                            Id = "3",
                            Correo = "martina67@gmail.com",
                            Edad = "6",
                            Nombre = "Martina Merino"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
