using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApi.DataAccessLayer;
using MVCWebApi.Models;
using MVCWebApi.Services;
using MVCWebApi.Repositories;

namespace MVCWebApi.Controllers
{
    public class ContactController : Controller
    {
        private readonly ICRUD<Contact> _service;

        public ContactController(LibraryContext dbContext)
        {
            _service = new Service<Contact>(new Repository<Contact>(dbContext));
        }

        [HttpGet("Contact/getAll")]
        public async Task<IActionResult> getAll()
        {
            return Json(await _service.GetAll());
        }

        [HttpPost("Contact/Create")]
        public async Task Create([FromBody] Contact contact)
        {
            await _service.Create(contact);
        }

        [HttpGet("Contact/Read/{id}")]
        public async Task<IActionResult> Read(int? id)
        {
            return Json(await _service.Read(id));
        }

        [HttpPost("Contact/Update")]
        public async Task Update([FromBody] Contact contact)
        {
            await _service.Update(contact);
        }

        [HttpGet("Contact/Delete/{id}")]
        public async Task Delete(int? id)
        {
            await _service.Delete(id);
        }
    }
}
