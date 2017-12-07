using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.Models
{
    
    public class Author : EntityModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        //public virtual List<BookAuthors> BookAuthors { get; set; } = new List<BookAuthors>();
    }
}
