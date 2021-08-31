﻿// <auto-generated />
using System;
using BibliotecaDrCash;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace back_end_challenge.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutorLivro", b =>
                {
                    b.Property<Guid>("AutoresId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LivrosId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AutoresId", "LivrosId");

                    b.HasIndex("LivrosId");

                    b.ToTable("AutorLivro");
                });

            modelBuilder.Entity("BibliotecaDrCash.Models.Autor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("BibliotecaDrCash.Models.Genero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("BibliotecaDrCash.Models.Livro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NumCopias")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("GeneroLivro", b =>
                {
                    b.Property<Guid>("GenerosId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LivrosId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GenerosId", "LivrosId");

                    b.HasIndex("LivrosId");

                    b.ToTable("GeneroLivro");
                });

            modelBuilder.Entity("AutorLivro", b =>
                {
                    b.HasOne("BibliotecaDrCash.Models.Autor", null)
                        .WithMany()
                        .HasForeignKey("AutoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BibliotecaDrCash.Models.Livro", null)
                        .WithMany()
                        .HasForeignKey("LivrosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GeneroLivro", b =>
                {
                    b.HasOne("BibliotecaDrCash.Models.Genero", null)
                        .WithMany()
                        .HasForeignKey("GenerosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BibliotecaDrCash.Models.Livro", null)
                        .WithMany()
                        .HasForeignKey("LivrosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}