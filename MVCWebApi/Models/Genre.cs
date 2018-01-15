using MVCWebApi.Models.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.Models
{
    public class Genre : EntityModel
    {
        public string name { get; set; }

        public List<BookGenres> BooksGenres { get; set; }

        public virtual List<BookGenres> BookGenres { get; set; } = new List<BookGenres>();
    }
}
