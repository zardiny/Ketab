using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ketab;

namespace Ketab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KetabInfoController : ControllerBase
    {
        private readonly DBAccess _context;

        public KetabInfoController(DBAccess context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetCategories()
        {
            return await _context.BooksInfo.Select(x => x.Category).Distinct().ToListAsync();
        }

        [HttpGet("{category}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks(string category)
        {
            var books = _context.BooksInfo.Where(x => x.Category == category);

            if (books == null)
            {
                return NotFound();
            }
            return await books.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            _context.BooksInfo.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBook", new { id = book.Id }, book);
        }

        

        private bool BookExists(long id)
        {
            return _context.BooksInfo.Any(e => e.Id == id);
        }
    }
}
