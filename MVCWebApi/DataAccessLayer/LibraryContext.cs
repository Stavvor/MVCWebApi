using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCWebApi.Models;
using System.Reflection;


namespace MVCWebApi.DataAccessLayer
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        { }

        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> book { get; set; }
        public DbSet<Client> client { get; set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<Publisher> publisher { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthors>()
            .HasKey(t => new { t.BookId, t.AuthorId });
        }
    }
}
