using MVCWebApi.Models.ManyToMany;
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
        public int PageNumber { get; set; }
        public DateTime PublishDate { get; set; }
        public string Binding { get; set; }
        public int PublisherId { get; set; }
        public int Price { get; set; }

        public List<BookOrders> BooksOrders { get; set; }
        public List<BookGenres> BooksGenres { get; set; }
        public List<BookAuthors> BooksAuthors { get; set; }
        public Publisher Publisher { get; set; }

        //public virtual List<BookAuthors> BookAuthors { get; set; } = new List<BookAuthors>();
        //public virtual List<BookGenres> BookGenres { get; set; } = new List<BookGenres>();
        //public virtual List<BookOrders> BookOrders { get; set; } = new List<BookOrders>();
    }
}
