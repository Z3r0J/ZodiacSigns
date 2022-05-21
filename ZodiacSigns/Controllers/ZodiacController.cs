using Application.Services;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZodiacSigns.Controllers
{

    public class ZodiacController : Controller
    {
        private readonly InformationViewModel information;
        private readonly ZodiacService zodiacService;

        public ZodiacController()
        {
            information = new();
            zodiacService = new();
        }
        public IActionResult Index()
        {
            return View(information);
        }
        public IActionResult Result() {

            return View();
        }
        [HttpPost]
        public IActionResult Result(InformationViewModel vm) {
            var zodiac = zodiacService.GetResult(vm);
            
            return View(zodiac);
        }
    }
}
