using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MVCWebApi.DataAccessLayer
{
    public class BookInitializer : DropCreateDatabaseAlways<BookContext>
    {

        //TODO zapytac czy potrzebne
    }
}
