using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KetabInfo;

namespace Ketab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksWebAPIController : ControllerBase
    {
        private readonly DBAccess _context;

        public BooksWebAPIController(DBAccess context)
        {
            _context = context;
        }

        // GET: api/BooksWebAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetCategories()
        {
            return await _context.BooksInfo.Select(x => x.Category).Distinct().ToListAsync();
        }


        [HttpGet("{category}")]
        public async Task<ActionResult<IEnumerable<string>>> GetBooks(string category)
        {
            var books = _context.BooksInfo.Where(x => x.Category == category);

            if (books == null)
            {
                return NotFound();
            }
            return await books.Select(x=> x.Name).Distinct().ToListAsync();
        }
    }
}
