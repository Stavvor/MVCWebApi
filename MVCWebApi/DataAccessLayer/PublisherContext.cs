using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.DataAccessLayer
{
    public class PublisherContext : DbContext
    {
        public PublisherContext() : base("") //TODO DB connection string
        { }

        public DbSet<Publisher> Publishers { get; set; }
    }
}
