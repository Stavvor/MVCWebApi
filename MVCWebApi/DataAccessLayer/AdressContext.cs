using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.DataAccessLayer
{
    public class AdressContext : DbContext
    {
        public AdressContext() : base("") //TODO DB connection string
        { }

        public DbSet<Adress> Adresses { get; set; }
    }
}
