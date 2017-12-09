using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApi.DataAccessLayer;
using MVCWebApi.Models;
using MVCWebApi.Services;

namespace MVCWebApi.Controllers
{
    public class GenreController : Controller
    {
        private readonly Service<Genre> _service;

        public GenreController(LibraryContext dbContext)
        {
            _service = new Service<Genre>(dbContext);
        }

        [HttpGet("Genre/getAll")]
        public async Task<IActionResult> getAll()
        {
            return Json(await _service.GetAll());
        }

        [HttpPost("Genre/Create")]
        public async Task Create([FromBody] Genre genre)
        {
            await _service.Create(genre);
        }

        [HttpGet("Genre/Read/{id}")]
        public async Task<IActionResult> Read(int? id)
        {
            return Json(await _service.Read(id));
        }

        [HttpPost("Genre/Update")]
        public async Task Update([FromBody] Genre genre)
        {
            await _service.Update(genre);
        }

        [HttpGet("Genre/Delete/{id}")]
        public async Task Delete(int? id)
        {
            await _service.Delete(id);
        }
    }
}
