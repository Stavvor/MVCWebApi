using Microsoft.EntityFrameworkCore;
using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.DataAccessLayer
{
    public class ClientContext : DbContext
    {
        public ClientContext()//TODO DB connection string
        { }

        public DbSet<Client> Clients { get; set; }
    }
}
