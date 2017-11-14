using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.DataAccessLayer
{
    public class BookContext 
    {
        public BookContext()  //TODO DB connection string
        { }

        public DbSet<Book> Books { get; set; }
    }
}
