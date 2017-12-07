using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MVCWebApi.Models
{
    public class Book : EntityModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public int Test { get; set; }


        //   public virtual Publisher Publisher { get; set; }

        //public virtual List<BookAuthors> BookAuthors { get; set; } = new List<BookAuthors>();
      //  public virtual List<Genre> Genres { get; set; }
      //  public virtual List<Order> Orders { get; set; }
    }
}
