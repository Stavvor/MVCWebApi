using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApi.DataAccessLayer;
using MVCWebApi.Models;
using MVCWebApi.Services;
using MVCWebApi.Repositories;

namespace MVCWebApi.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ICRUD<Author> _service;

        public AuthorController(LibraryContext dbContext)
        {
            _service = new Service<Author>(new Repository<Author>(dbContext));
        }

        [HttpGet("Author/getAll")]
        public async Task<IActionResult> getAll()
        {
            return Json(await _service.GetAll());
        }

        [HttpPost("Author/Create")]
        public async Task Create([FromBody] Author author)
        {
            await _service.Create(author);
        }

        [HttpGet("Author/Read/{id}")]
        public async Task<IActionResult> Read(int? id)
        {
            return Json(await _service.Read(id));
        }

        [HttpPost("Author/Update")]
        public async Task Update([FromBody] Author author)
        {
            await _service.Update(author);
        }

        [HttpGet("Author/Delete/{id}")]
        public async Task Delete(int? id)
        {
            await _service.Delete(id);
        }
    }
}
