using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.DataAccessLayer
{
    public class ContactContext : DbContext
    {
        public ContactContext() : base("") //TODO DB connection string
        { }

        public DbSet<Contact> Contacts { get; set; }
    }
}
