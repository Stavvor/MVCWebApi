using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApi.DataAccessLayer;
using MVCWebApi.Models;
using MVCWebApi.Repositories;
using MVCWebApi.Services;

namespace MVCWebApi.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICRUD<Order> _service;

        public OrderController(LibraryContext dbContext)
        {
            _service = new Service<Order>(new Repository<Order>(dbContext));
        }

        [HttpGet("Order/getAll")]
        public async Task<IActionResult> getAll()
        {
            return Json(await _service.GetAll());
        }

        [HttpGet("Order/getPage")]
        public async Task<IActionResult> GetPage(int pageIndex, int pageSize)
        {
            return Json(await _service.GetPage(pageIndex, pageSize));
        }

        [HttpPost("Order/Create")]
        public async Task Create([FromBody] Order order)
        {
            await _service.Create(order);
        }

        [HttpGet("Order/Read/{id}")]
        public async Task<IActionResult> Read(int? id)
        {
            return Json(await _service.Read(id));
        }

        [HttpPost("Order/Update")]
        public async Task Update([FromBody] Order order)
        {
            await _service.Update(order);
        }

        [HttpGet("Order/Delete/{id}")]
        public async Task Delete(int? id)
        {
            await _service.Delete(id);
        }
    }
}
