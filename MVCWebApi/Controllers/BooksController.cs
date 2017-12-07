using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCWebApi.DataAccessLayer;
using MVCWebApi.Models;
using MVCWebApi.Services;

namespace MVCWebApi.Controllers
{
    public class BooksController : Controller
    {
        private readonly Service<Book> _service;
        private readonly LibraryContext _context;

        public BooksController(LibraryContext dbContext)
        {
            _context = dbContext;
            _service = new Service<Book>(_context);
        }

        // GET: Books
        [HttpGet("Books/getAll")]
        public async Task<IActionResult> getAll()
        {   
            return Json(await _service.GetAll());
        }

        // GET: Books/Details/5
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            return Json(await _service.Read(id));
        }

        // POST: Books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("Books/Create")]
        public async Task<IActionResult> Create([FromBody] Book book)
        {
            await _service.Create(book);
            return Json(book);  //zapytac
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("Books/Edit")]
        public async Task Edit(int id, [FromBody] Book book)
        {
           await _service.Update(id, book);
        }

        // GET: Books/Delete/5
        [HttpGet("Books/Delete/{id}")]
        public async Task Delete(int id)
        {
            await _service.Delete(id);
        }
    }
}
