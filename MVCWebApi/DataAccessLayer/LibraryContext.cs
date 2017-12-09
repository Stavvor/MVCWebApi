using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCWebApi.Models;
using System.Reflection;
using MVCWebApi.Models.ManyToMany;

namespace MVCWebApi.DataAccessLayer
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        { }

        public DbSet<Adress> Adress { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Contact> Contact { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder
            //.Entity<Adress>()
            //.HasOne(a => a.Client)
            //.WithOne()
            //.HasForeignKey<Client>();
            //
            //modelBuilder
            //.Entity<Contact>()
            //.HasOne(a => a.Client)
            //.WithOne()
            //.HasForeignKey<Client>();
            //
            //modelBuilder
            //.Entity<Book>()
            //.HasOne(a => a.Publisher)
            //.WithOne()
            //.HasForeignKey<Publisher>();
            //
            //modelBuilder.Entity<BookAuthors>()
            //.HasKey(b => new { b.BookId, b.AuthorId });
            //
            //modelBuilder.Entity<BookAuthors>()
            //.HasOne(ba => ba.Book)
            //.WithMany(b => b.BookAuthors)
            //.HasForeignKey(ba => ba.BookId);
            //
            //modelBuilder.Entity<BookAuthors>()
            //.HasOne(ba => ba.Author)
            //.WithMany(b => b.BookAuthors)
            //.HasForeignKey(ba => ba.AuthorId);
            //
            //
            //modelBuilder.Entity<BookGenres>()
            //.HasKey(b => new { b.BookId, b.GenreId });
            //
            //modelBuilder.Entity<BookGenres>()
            //.HasOne(bg => bg.Book)
            //.WithMany(b => b.BookGenres)
            //.HasForeignKey(bg => bg.BookId);
            //
            //modelBuilder.Entity<BookGenres>()
            //.HasOne(bg => bg.Genre)
            //.WithMany(b => b.BookGenres)
            //.HasForeignKey(bg => bg.GenreId);


            //modelBuilder.Entity<BookOrders>()
            //.HasKey(b => new { b.BookId, b.OrderId });
            //
            //modelBuilder.Entity<BookOrders>()
            //.HasOne(bo => bo.Book)
            //.WithMany(b => b.BookOrders)
            //.HasForeignKey(bo => bo.BookId);
            //
            //modelBuilder.Entity<BookOrders>()
            //.HasOne(bo => bo.Order)
            //.WithMany(b => b.BookOrders)
            //.HasForeignKey(bo => bo.Order.Id);
        }
    }
}
