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
    [Migration("20230227115723_BookIdInRentedBookMigration")]
    partial class BookIdInRentedBookMigration
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

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
                            CreatedDate = new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1360),
                            FirstName = "Ljubo",
                            IsDeleted = false,
                            LastName = "Nedovic",
                            ModifiedDate = new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1363)
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1369),
                            FirstName = "Rade",
                            IsDeleted = false,
                            LastName = "Doroslovacki",
                            ModifiedDate = new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1371)
                        },
                        new
                        {
                            Id = 3L,
                            CreatedDate = new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1374),
                            FirstName = "Damir",
                            IsDeleted = false,
                            LastName = "Madjarevic",
                            ModifiedDate = new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1376)
                        });
                });

            modelBuilder.Entity("LibraryApp.Models.Book", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<byte[]>("Cover")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedDate = new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1159),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1169),
                            Name = "Algebra Testovi",
                            Quantity = 2
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1213),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1216),
                            Name = "Algebra",
                            Quantity = 1
                        },
                        new
                        {
                            Id = 3L,
                            CreatedDate = new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1220),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1221),
                            Name = "Mehanika",
                            Quantity = 2
                        },
                        new
                        {
                            Id = 4L,
                            CreatedDate = new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1225),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1227),
                            Name = "Zbirka zadataka iz Mehanike",
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("LibraryApp.Models.RentedBook", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("BookId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("RentedBooks");
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

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

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedDate = new DateTime(2023, 2, 27, 12, 57, 22, 493, DateTimeKind.Local).AddTicks(1930),
                            Email = "dane.m.12@gmail.com",
                            FirstName = "Dane",
                            IsDeleted = false,
                            LastName = "Milisic",
                            ModifiedDate = new DateTime(2023, 2, 27, 12, 57, 22, 493, DateTimeKind.Local).AddTicks(1970),
                            Password = "E1BB34D88E6C660FECFCDCEB783743F3C2D2CFDCFFF6719CBF9814AB1337356469723F830081622FA6C4AE7601F7D66F543990B775023A253673E9D59202C2D7",
                            Role = "USER",
                            Salt = new byte[] { 204, 81, 216, 242, 144, 181, 39, 37, 229, 44, 146, 187, 40, 21, 20, 254, 40, 173, 63, 220, 114, 31, 115, 212, 224, 89, 208, 71, 130, 39, 196, 38, 161, 221, 154, 193, 188, 184, 173, 55, 32, 66, 143, 13, 230, 163, 236, 39, 201, 74, 89, 29, 183, 135, 133, 133, 115, 196, 162, 220, 167, 138, 224, 33 }
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2023, 2, 27, 12, 57, 22, 732, DateTimeKind.Local).AddTicks(7157),
                            Email = "woox.gg@gmail.com",
                            FirstName = "Nikola",
                            IsDeleted = false,
                            LastName = "Vukic",
                            ModifiedDate = new DateTime(2023, 2, 27, 12, 57, 22, 732, DateTimeKind.Local).AddTicks(7202),
                            Password = "F7E0B7C00F782D52DA5EBB8B41597417740372DCA745EEE826B1035C3C6F130AD8917431595ED5A8BC0F6AEFCA201FB9EF9897F6F1448F8931BD010C2F4456C9",
                            Role = "LIBRARIAN",
                            Salt = new byte[] { 100, 189, 211, 152, 63, 167, 27, 91, 10, 73, 92, 110, 133, 78, 46, 25, 4, 191, 3, 25, 120, 236, 49, 99, 65, 105, 107, 135, 59, 22, 60, 61, 176, 216, 114, 96, 173, 222, 119, 247, 44, 9, 3, 3, 104, 9, 95, 47, 185, 72, 19, 97, 200, 8, 112, 46, 140, 102, 46, 102, 245, 203, 154, 33 }
                        },
                        new
                        {
                            Id = 3L,
                            CreatedDate = new DateTime(2023, 2, 27, 12, 57, 22, 975, DateTimeKind.Local).AddTicks(7000),
                            Email = "djokeen@gmail.com",
                            FirstName = "Djordje",
                            IsDeleted = false,
                            LastName = "Rasic",
                            ModifiedDate = new DateTime(2023, 2, 27, 12, 57, 22, 975, DateTimeKind.Local).AddTicks(7042),
                            Password = "5574CCE6AB67D26FB3F99667E9A6F08C653690E1F9B20E67C3CFC71678B8981D8F5107FB3E29CFB4F2C0DBA24781B937C342DA2A4CFDB92028157A636BA5FC79",
                            Role = "ADMIN",
                            Salt = new byte[] { 103, 26, 147, 192, 138, 166, 189, 221, 158, 146, 152, 65, 186, 210, 152, 76, 150, 82, 161, 7, 243, 119, 185, 128, 28, 194, 31, 240, 209, 149, 231, 219, 66, 72, 16, 83, 195, 242, 120, 239, 73, 117, 130, 255, 8, 137, 158, 61, 234, 84, 58, 229, 95, 0, 191, 2, 190, 60, 69, 84, 252, 209, 157, 65 }
                        },
                        new
                        {
                            Id = 4L,
                            CreatedDate = new DateTime(2023, 2, 27, 12, 57, 23, 219, DateTimeKind.Local).AddTicks(9916),
                            Email = "kikimaher@gmail.com",
                            FirstName = "Kristijan",
                            IsDeleted = true,
                            LastName = "Trnjanac",
                            ModifiedDate = new DateTime(2023, 2, 27, 12, 57, 23, 219, DateTimeKind.Local).AddTicks(9959),
                            Password = "2C47D28F7C679412276F215C3769FEEC98CC2CED79D1792BD9EC392F55A6F6BDF02C6FB26FE9790FDA9FF0B5E5E6755786B032E2DB102C62432D174B50502005",
                            Role = "USER",
                            Salt = new byte[] { 117, 58, 142, 152, 74, 37, 81, 116, 33, 1, 221, 23, 37, 71, 159, 42, 98, 166, 10, 160, 132, 35, 1, 186, 160, 148, 135, 25, 240, 223, 192, 43, 35, 177, 201, 246, 195, 135, 125, 113, 37, 157, 208, 68, 241, 215, 212, 144, 159, 47, 47, 48, 80, 209, 245, 17, 23, 210, 242, 123, 140, 175, 165, 206 }
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

            modelBuilder.Entity("LibraryApp.Models.RentedBook", b =>
                {
                    b.HasOne("LibraryApp.Models.Book", "Book")
                        .WithMany("RentedBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryApp.Models.User", "User")
                        .WithMany("RentedBooks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LibraryApp.Models.Book", b =>
                {
                    b.Navigation("RentedBooks");
                });

            modelBuilder.Entity("LibraryApp.Models.User", b =>
                {
                    b.Navigation("RentedBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
