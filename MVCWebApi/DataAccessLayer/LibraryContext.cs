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

        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthors> BooksAuthors { get; set; }
        public DbSet<Book> book { get; set; }
        public DbSet<BookGenres> BooksGenres { get; set; }
        public DbSet<Client> client { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<BookOrders> BooksOrders { get; set; }
        public DbSet<Publisher> publisher { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthors>().HasKey(c => new { c.AuthorId, c.BookId });
            modelBuilder.Entity<BookGenres>().HasKey(c => new { c.BookId, c.GenreId });
            modelBuilder.Entity<BookOrders>().HasKey(c => new { c.OrderId, c.BookId });
        }

    }
}
