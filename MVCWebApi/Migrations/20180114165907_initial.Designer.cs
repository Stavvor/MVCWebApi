﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MVCWebApi.DataAccessLayer;
using System;

namespace MVCWebApi.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20180114165907_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCWebApi.Models.Adress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<int>("ClientId");

                    b.Property<string>("Country");

                    b.Property<int>("FlatNumber");

                    b.Property<int>("HouseNumber");

                    b.Property<int>("PostalCode");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Adress");
                });

            modelBuilder.Entity("MVCWebApi.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("MVCWebApi.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Binding");

                    b.Property<int>("PageNumber");

                    b.Property<int>("Price");

                    b.Property<DateTime>("PublishDate");

                    b.Property<int>("PublisherId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("MVCWebApi.Models.BookAuthors", b =>
                {
                    b.Property<int>("AuthorId");

                    b.Property<int>("BookId");

                    b.Property<int>("Id");

                    b.HasKey("AuthorId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthors");
                });

            modelBuilder.Entity("MVCWebApi.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdressId");

                    b.Property<int>("ContactId");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("MVCWebApi.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<int?>("ClientId1");

                    b.Property<string>("Email");

                    b.Property<int>("PhoneNumber1");

                    b.Property<int>("PhoneNumber2");

                    b.HasKey("Id");

                    b.HasIndex("ClientId1");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("MVCWebApi.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("MVCWebApi.Models.ManyToMany.BookGenres", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("GenreId");

                    b.Property<int>("Id");

                    b.HasKey("BookId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("BooksGenres");
                });

            modelBuilder.Entity("MVCWebApi.Models.ManyToMany.BookOrders", b =>
                {
                    b.Property<int>("OrderId");

                    b.Property<int>("BookId");

                    b.Property<int>("Id");

                    b.HasKey("OrderId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("BookOrders");
                });

            modelBuilder.Entity("MVCWebApi.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("RealizationDate");

                    b.Property<DateTime>("SubmitDate");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("MVCWebApi.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("MVCWebApi.Models.Adress", b =>
                {
                    b.HasOne("MVCWebApi.Models.Client", "Client")
                        .WithMany("Adresses")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MVCWebApi.Models.Book", b =>
                {
                    b.HasOne("MVCWebApi.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MVCWebApi.Models.BookAuthors", b =>
                {
                    b.HasOne("MVCWebApi.Models.Author", "Author")
                        .WithMany("BooksAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MVCWebApi.Models.Book", "Book")
                        .WithMany("BooksAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MVCWebApi.Models.Contact", b =>
                {
                    b.HasOne("MVCWebApi.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId1");
                });

            modelBuilder.Entity("MVCWebApi.Models.ManyToMany.BookGenres", b =>
                {
                    b.HasOne("MVCWebApi.Models.Book", "Book")
                        .WithMany("BooksGenres")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MVCWebApi.Models.Genre", "Genre")
                        .WithMany("BooksGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MVCWebApi.Models.ManyToMany.BookOrders", b =>
                {
                    b.HasOne("MVCWebApi.Models.Book", "Book")
                        .WithMany("BooksOrders")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MVCWebApi.Models.Order", "Order")
                        .WithMany("BooksOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MVCWebApi.Models.Order", b =>
                {
                    b.HasOne("MVCWebApi.Models.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}