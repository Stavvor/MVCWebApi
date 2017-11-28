using Microsoft.EntityFrameworkCore;
using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.DataAccessLayer
{
    public class OrderContext : DbContext
    {
        public OrderContext() //TODO DB connection string
        { }

        public DbSet<Order> Orders { get; set; }
    }
}
