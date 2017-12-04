using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCWebApi.DataAccessLayer;
using MVCWebApi.Models;

namespace MVCWebApi.Controllers
{
    public class BooksController : Controller
    {
        private readonly LibraryContext _context;

        public BooksController(LibraryContext context)
        {
            _context = context;
        }

        // GET: Books
        [HttpGet("Books/Index")]
        public async Task<IActionResult> Index()
        {
            return Json(await _context.book.ToListAsync());
        }

        // GET: Books/Details/5
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.book
                .SingleOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }
            return Json(book);
        }

        // POST: Books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("Books/Create")]
        public async Task<IActionResult> Create([FromBody] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return Json(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("Books/Edit")]
        public async Task<IActionResult> Edit(int id, [FromBody] Book book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var toEdit = await _context.book
                    .SingleOrDefaultAsync(m => m.BookId == id);

                    toEdit.Title = book.Title;
                    toEdit.Author = book.Author;
                    toEdit.Price = book.Price;
                    toEdit.Author = book.Author;
                    toEdit.Test = book.Test;

                    _context.Update(toEdit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return Json(book);
        }

        // GET: Books/Delete/5
        [HttpGet("Books/Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
     
            var book = await _context.book
                .SingleOrDefaultAsync(m => m.BookId == id);
            if (book == null) return NotFound();
            
            _context.Remove(book);
            await _context.SaveChangesAsync();
            return Json(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.book.SingleOrDefaultAsync(m => m.BookId == id);
            _context.book.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.book.Any(e => e.BookId == id);
        }

        private void BookEdit(Book target, Book source)
        {

        }
    }
}
