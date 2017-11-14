using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.DataAccessLayer
{
    public class AuthorContext 
    {
        public AuthorContext()  //TODO DB connection string
        { }

        public DbSet<Author> Authors { get; set; }
    }
}
