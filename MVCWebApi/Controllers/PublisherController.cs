using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApi.DataAccessLayer;
using MVCWebApi.Models;
using MVCWebApi.Services;

namespace MVCWebApi.Controllers
{
    public class PublisherController : Controller
    {
        private readonly Service<Publisher> _service;

        public PublisherController(LibraryContext dbContext)
        {
            _service = new Service<Publisher>(dbContext);
        }

        [HttpGet("Publisher/getAll")]
        public async Task<IActionResult> getAll()
        {
            return Json(await _service.GetAll());
        }

        [HttpPost("Publisher/Create")]
        public async Task Create([FromBody] Publisher publisher)
        {
            await _service.Create(publisher);
        }

        [HttpGet("Publisher/Read/{id}")]
        public async Task<IActionResult> Read(int? id)
        {
            return Json(await _service.Read(id));
        }

        [HttpPost("Publisher/Update")]
        public async Task Update([FromBody] Publisher publisher)
        {
            await _service.Update(publisher);
        }

        [HttpGet("Publisher/Delete/{id}")]
        public async Task Delete(int? id)
        {
            await _service.Delete(id);
        }
    }
}
