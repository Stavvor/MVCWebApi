using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.DataAccessLayer
{
    public class OrderContext : DbContext
    {
        public OrderContext() : base("") //TODO DB connection string
        { }

        public DbSet<Order> Orders { get; set; }
    }
}
