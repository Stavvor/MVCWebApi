using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MVCWebApi.Models
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int BookId { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int Test { get; set; }


     //   public virtual Publisher Publisher { get; set; }

      //  public virtual List<Author> Authors { get; set; } 
      //  public virtual List<Genre> Genres { get; set; }
      //  public virtual List<Order> Orders { get; set; }
    }
}
