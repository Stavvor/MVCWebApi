using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.Models
{
    public class Client : EntityModel
    {
        public int AdressId { get; set; }
        public int ContactId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        //public List<Adress> Adresses { get; set; }
        //public List<Order> Orders { get; set; }

    }
}
