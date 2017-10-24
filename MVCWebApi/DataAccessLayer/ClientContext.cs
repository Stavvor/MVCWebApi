using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.DataAccessLayer
{
    public class ClientContext : DbContext
    {
        public ClientContext() : base("") //TODO DB connection string
        { }

        public DbSet<Client> Clients { get; set; }
    }
}
