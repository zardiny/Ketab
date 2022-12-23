using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;



namespace Ketab.Controllers
{
    public class Questions : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
