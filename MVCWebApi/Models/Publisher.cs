using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.Models
{
    public class Publisher : EntityModel
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public List<Book> Books { get; set; }
    }
}
