using Microsoft.EntityFrameworkCore;
using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.DataAccessLayer
{
    public class ContactContext : DbContext
    {
        public ContactContext()//TODO DB connection string
        { }

        public DbSet<Contact> Contacts { get; set; }
    }
}
