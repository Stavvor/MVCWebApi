using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.DataAccessLayer
{
    public class GenreContext : DbContext
    {
        public GenreContext() : base("") //TODO DB connection string
        { }

        public DbSet<Genre> Genres { get; set; }
    }
}
