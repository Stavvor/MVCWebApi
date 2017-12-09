using MVCWebApi.Models.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.Models
{
    public class Order : EntityModel
    {
        public int ClientId { get; set; }
        public DateTime SubmitDate { get; set; }
        public DateTime RealizationDate { get; set; }

        //public virtual Client Client { get; set; }
        //public virtual List<BookOrders> BookOrders { get; set; } = new List<BookOrders>();
    }
}
