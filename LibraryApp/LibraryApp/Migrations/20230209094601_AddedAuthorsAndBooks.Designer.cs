﻿// <auto-generated />
using System;
using LibraryApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryApp.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20230209094601_AddedAuthorsAndBooks")]
    partial class AddedAuthorsAndBooks
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<long>("AuthorsId")
                        .HasColumnType("bigint");

                    b.Property<long>("BooksId")
                        .HasColumnType("bigint");

                    b.HasKey("AuthorsId", "BooksId");

                    b.HasIndex("BooksId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("LibraryApp.Models.Author", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8630),
                            FirstName = "Ljubo",
                            LastName = "Nedovic",
                            ModifiedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8631)
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8635),
                            FirstName = "Rade",
                            LastName = "Doroslovacki",
                            ModifiedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8636)
                        },
                        new
                        {
                            Id = 3L,
                            CreatedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8639),
                            FirstName = "Damir",
                            LastName = "Madjarevic",
                            ModifiedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8640)
                        });
                });

            modelBuilder.Entity("LibraryApp.Models.Book", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8607),
                            ModifiedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8608),
                            Name = "Algebra Testovi"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8612),
                            ModifiedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8613),
                            Name = "Algebra"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8615),
                            ModifiedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8616),
                            Name = "Mehanika"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8618),
                            ModifiedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8619),
                            Name = "Zbirka zadataka iz Mehanike"
                        });
                });

            modelBuilder.Entity("LibraryApp.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<byte[]>("Avatar")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8538),
                            Email = "dane.m.12@gmail.com",
                            FirstName = "Dane",
                            LastName = "Milisic",
                            ModifiedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8574),
                            Password = "123",
                            Role = "USER"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8590),
                            Email = "woox.gg@gmail.com",
                            FirstName = "Nikola",
                            LastName = "Vukic",
                            ModifiedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8592),
                            Password = "123",
                            Role = "LIBRARIAN"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8595),
                            Email = "djokeen@gmail.com",
                            FirstName = "Djordje",
                            LastName = "Rasic",
                            ModifiedDate = new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8596),
                            Password = "123",
                            Role = "ADMIN"
                        });
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("LibraryApp.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryApp.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
