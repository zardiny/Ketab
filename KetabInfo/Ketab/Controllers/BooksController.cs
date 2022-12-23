using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KetabInfo;

namespace Ketab.Controllers
{
    public class BooksController : Controller
    {
        // GET: Categories
        public async Task<IActionResult> Index()
        {
              return View();
        }

        public async Task<IActionResult> FirstPage()
        {
            return View();
        }

    }
}
