﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThuVierApi.DbContexts;

#nullable disable

namespace ThuVierApi.Migrations
{
    [DbContext(typeof(ConText))]
    partial class ConTextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ThuVienMVC.Models.Admin", b =>
                {
                    b.Property<int>("IdAmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAmin"));

                    b.Property<string>("AminName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Createdat")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameAdmin")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Updatedat")
                        .HasColumnType("datetime2");

                    b.Property<bool>("deleteflag")
                        .HasColumnType("bit");

                    b.HasKey("IdAmin");

                    b.ToTable("admins", (string)null);
                });

            modelBuilder.Entity("ThuVienMVC.Models.Author", b =>
                {
                    b.Property<int>("IdAuthor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAuthor"));

                    b.Property<DateTime>("Createdat")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameAuthor")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Updatedat")
                        .HasColumnType("datetime2");

                    b.Property<bool>("deleteflag")
                        .HasColumnType("bit");

                    b.HasKey("IdAuthor");

                    b.ToTable("authors", (string)null);
                });

            modelBuilder.Entity("ThuVienMVC.Models.Book", b =>
                {
                    b.Property<int>("IdBook")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBook"));

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Createdat")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("PublishingYear")
                        .HasColumnType("int");

                    b.Property<int?>("QuantityInStock")
                        .HasColumnType("int");

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Updatedat")
                        .HasColumnType("datetime2");

                    b.Property<bool>("deleteflag")
                        .HasColumnType("bit");

                    b.HasKey("IdBook");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.ToTable("books", (string)null);
                });

            modelBuilder.Entity("ThuVienMVC.Models.Borrowing", b =>
                {
                    b.Property<int>("IdBor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBor"));

                    b.Property<DateTime>("ActualEndAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Createdat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Endat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Startat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Updatedat")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("deleteflag")
                        .HasColumnType("bit");

                    b.HasKey("IdBor");

                    b.HasIndex("UserId");

                    b.ToTable("borrowings", (string)null);
                });

            modelBuilder.Entity("ThuVienMVC.Models.BorrowingItems", b =>
                {
                    b.Property<int>("IDitem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDitem"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("BorrowingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Createdat")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updatedat")
                        .HasColumnType("datetime2");

                    b.Property<bool>("deleteflag")
                        .HasColumnType("bit");

                    b.HasKey("IDitem");

                    b.HasIndex("BookId");

                    b.HasIndex("BorrowingId");

                    b.ToTable("borrowing_items", (string)null);
                });

            modelBuilder.Entity("ThuVienMVC.Models.Genre", b =>
                {
                    b.Property<int>("IdGenres")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGenres"));

                    b.Property<DateTime>("Createdat")
                        .HasColumnType("datetime2");

                    b.Property<int>("NameGenres")
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("int");

                    b.Property<DateTime>("Updatedat")
                        .HasColumnType("datetime2");

                    b.Property<bool>("deleteflag")
                        .HasColumnType("bit");

                    b.HasKey("IdGenres");

                    b.ToTable("geres", (string)null);
                });

            modelBuilder.Entity("ThuVienMVC.Models.Rating", b =>
                {
                    b.Property<int>("IdRate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRate"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Createdat")
                        .HasColumnType("datetime2");

                    b.Property<int>("Star")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updatedat")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("deleteflag")
                        .HasColumnType("bit");

                    b.HasKey("IdRate");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("ratings", (string)null);
                });

            modelBuilder.Entity("ThuVienMVC.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<DateTime>("Createdat")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameUser")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Updatedat")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("deleteflag")
                        .HasColumnType("bit");

                    b.HasKey("IdUser");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("ThuVienMVC.Models.Book", b =>
                {
                    b.HasOne("ThuVienMVC.Models.Author", "Author")
                        .WithMany("Book")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ThuVienMVC.Models.Genre", "Genre")
                        .WithMany("Book")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Author");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("ThuVienMVC.Models.Borrowing", b =>
                {
                    b.HasOne("ThuVienMVC.Models.User", "User")
                        .WithMany("Borrowing")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ThuVienMVC.Models.BorrowingItems", b =>
                {
                    b.HasOne("ThuVienMVC.Models.Book", "Book")
                        .WithMany("BorrowingItems")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ThuVienMVC.Models.Borrowing", "Borrowing")
                        .WithMany("BorrowingItems")
                        .HasForeignKey("BorrowingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Borrowing");
                });

            modelBuilder.Entity("ThuVienMVC.Models.Rating", b =>
                {
                    b.HasOne("ThuVienMVC.Models.Book", "Book")
                        .WithMany("Rating")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ThuVienMVC.Models.User", "User")
                        .WithMany("Rating")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ThuVienMVC.Models.Author", b =>
                {
                    b.Navigation("Book");
                });

            modelBuilder.Entity("ThuVienMVC.Models.Book", b =>
                {
                    b.Navigation("BorrowingItems");

                    b.Navigation("Rating");
                });

            modelBuilder.Entity("ThuVienMVC.Models.Borrowing", b =>
                {
                    b.Navigation("BorrowingItems");
                });

            modelBuilder.Entity("ThuVienMVC.Models.Genre", b =>
                {
                    b.Navigation("Book");
                });

            modelBuilder.Entity("ThuVienMVC.Models.User", b =>
                {
                    b.Navigation("Borrowing");

                    b.Navigation("Rating");
                });
#pragma warning restore 612, 618
        }
    }
}
