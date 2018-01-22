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
        public string PublishDate { get; set; }
        public string Binding { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public int Price { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        
    }
}
