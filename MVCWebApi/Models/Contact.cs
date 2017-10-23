using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int PhoneNumber1 { get; set; }
        public int PhoneNumber2 { get; set; }
        public string Email { get; set; }

        public virtual Client Client { get; set; }
    }
}
