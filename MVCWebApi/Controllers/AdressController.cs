using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApi.DataAccessLayer;
using MVCWebApi.Models;
using MVCWebApi.Repositories;
using MVCWebApi.Services;

namespace MVCWebApi.Controllers
{
    public class AdressController : Controller
    {
        private readonly ICRUD<Adress> _service;

        public AdressController(LibraryContext dbContext)
        {
            _service = new Service<Adress>(new Repository<Adress>(dbContext));
        }

        [HttpGet("Adress/getAll")]
        public async Task<IActionResult> getAll()
        {
            return Json(await _service.GetAll());
        }

        [HttpPost("Adress/Create")]
        public async Task Create([FromBody] Adress adress)
        {
            await _service.Create(adress);
        }

        [HttpGet("Adress/Read/{id}")]
        public async Task<IActionResult> Read(int? id)
        {
            return Json(await _service.Read(id));
        }

        [HttpPost("Adress/Update")]
        public async Task Update([FromBody] Adress adress)
        {
            await _service.Update(adress);
        }

        [HttpGet("Adress/Delete/{id}")]
        public async Task Delete(int? id)
        {
            await _service.Delete(id);
        }
    }
}
