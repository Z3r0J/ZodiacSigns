using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZodiacSigns.Controllers
{
    public class ZodiacController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Result() {

            return View();
        }
        [HttpPost]
        public IActionResult Result(InfoViewModel vm) { 
        
        }
    }
}
