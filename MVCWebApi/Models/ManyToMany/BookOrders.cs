using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.Models.ManyToMany
{
    public class BookOrders : EntityModel
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
