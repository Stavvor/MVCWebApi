using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public DateTime SubmitDate { get; set; }
        public DateTime RealizationDate { get; set; }

        public virtual Client Client { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
