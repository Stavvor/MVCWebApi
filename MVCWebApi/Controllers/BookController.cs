using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MVCWebApi.DataAccessLayer;
using MVCWebApi.Models;
using MVCWebApi.Services;

namespace MVCWebApi.Controllers
{
    public class BookController : Controller
    {
        private readonly Service<Book> _service;

        public BookController(LibraryContext dbContext)
        {
            _service = new Service<Book>(dbContext);
        }

        [HttpGet("Book/getAll")]
        [EnableCors("AllowAll")]
        public async Task<IActionResult> getAll()
        {
            return Json(await _service.GetAll());
        }

        [HttpPost("Book/Create")]
        public async Task Create([FromBody] Book book)
        {
            await _service.Create(book);
        }

        [HttpGet("Book/Read/{id}")]
        public async Task<IActionResult> Read(int? id)
        {
            return Json(await _service.Read(id));
        }

        [HttpPost("Book/Update")]
        public async Task Update([FromBody] Book book)
        {
           await _service.Update(book);
        }

        [HttpGet("Book/Delete/{id}")]
        public async Task Delete(int? id)
        {
            await _service.Delete(id);
        }
    }
}
