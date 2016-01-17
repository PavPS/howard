using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace howard.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult Run(string code)
        {
            return Json($"Executed:\n{code}");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
