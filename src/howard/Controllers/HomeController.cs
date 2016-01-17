using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Mvc;

namespace howard.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _environment;

        public HomeController(IHostingEnvironment environment)
        {
            if (environment == null) throw new ArgumentNullException(nameof(environment));
            _environment = environment;
        }

        [HttpPost]
        public IActionResult Run(string code)
        {
            code = WrapCode(code);

            var path = Path.Combine(_environment.WebRootPath, @"scripts\pi.py");
            System.IO.File.WriteAllText(path, code);

            return Json($"Executed:\n{code}");
        }

        private static string WrapCode(string code)
        {
            var sb = new StringBuilder();
            sb.AppendLine("import RPi.GPIO as GPIO");
            sb.AppendLine("import time");
            sb.AppendLine("GPIO.setmode(GPIO.BCM)");
            sb.AppendLine("GPIO.setup(21, GPIO.OUT)");
            sb.AppendLine("GPIO.output(21, True)");
            sb.AppendLine("time.sleep(1)");
            sb.AppendLine("GPIO.cleanup()");

            return sb.ToString();
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
