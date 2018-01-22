using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.Models
{
    public class Order : EntityModel
    {
        public int ClientId { get; set; }
        public string SubmitDate { get; set; }
        public string RealizationDate { get; set; }        
        public Client Client { get; set; }        
        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
