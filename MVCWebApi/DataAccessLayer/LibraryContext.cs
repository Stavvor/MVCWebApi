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

        public DbSet<Adress> Adress { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Publisher> Publisher { get; set; }

       
    }
}
