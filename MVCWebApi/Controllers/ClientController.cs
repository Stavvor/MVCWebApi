using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApi.DataAccessLayer;
using MVCWebApi.Models;
using MVCWebApi.Services;

namespace MVCWebApi.Controllers
{
    public class ClientController : Controller
    {
        private readonly Service<Client> _service;

        public ClientController(LibraryContext dbContext)
        {
            _service = new Service<Client>(dbContext);
        }

        [HttpGet("Client/getAll")]
        public async Task<IActionResult> getAll()
        {
            return Json(await _service.GetAll());
        }

        [HttpPost("Client/Create")]
        public async Task Create([FromBody] Client client)
        {
            await _service.Create(client);
        }

        [HttpGet("Client/Read/{id}")]
        public async Task<IActionResult> Read(int? id)
        {
            return Json(await _service.Read(id));
        }

        [HttpPost("Client/Update")]
        public async Task Update([FromBody] Client client)
        {
            await _service.Update(client);
        }

        [HttpGet("Client/Delete/{id}")]
        public async Task Delete(int? id)
        {
            await _service.Delete(id);
        }
    }
}
