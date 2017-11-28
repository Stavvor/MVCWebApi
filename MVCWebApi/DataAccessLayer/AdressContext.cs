using Microsoft.EntityFrameworkCore;
using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.DataAccessLayer
{
    public class AdressContext
    {
        public AdressContext()  //TODO DB connection string
        { }

        public DbSet<Adress> Adresses { get; set; }
    }
}
