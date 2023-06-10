﻿// <auto-generated />
using Ejercicio182.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ejercicio182.Migrations
{
    [DbContext(typeof(DBContexto))]
    [Migration("20230609231339_InitialCreate1")]
    partial class InitialCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ejercicio182.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClaseId");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("ClaseId");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("Ejercicio182.Models.Clase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColegioId");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("ColegioId");

                    b.ToTable("Clases");
                });

            modelBuilder.Entity("Ejercicio182.Models.Colegio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Colegios");
                });

            modelBuilder.Entity("Ejercicio182.Models.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClaseId");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("ClaseId");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("Ejercicio182.Models.Alumno", b =>
                {
                    b.HasOne("Ejercicio182.Models.Clase", "Clase")
                        .WithMany("Alumno")
                        .HasForeignKey("ClaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ejercicio182.Models.Clase", b =>
                {
                    b.HasOne("Ejercicio182.Models.Colegio", "Colegio")
                        .WithMany("Clases")
                        .HasForeignKey("ColegioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ejercicio182.Models.Profesor", b =>
                {
                    b.HasOne("Ejercicio182.Models.Clase", "Clase")
                        .WithMany("Profesor")
                        .HasForeignKey("ClaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
