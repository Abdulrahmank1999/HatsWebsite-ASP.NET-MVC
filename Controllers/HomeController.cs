using HatSelling.Models;
using HatSelling.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HatSelling.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHatService _Hat;

        public HomeController(IHatService Hat)
        {
            _Hat = Hat ;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hats()
        {
            return View(_Hat.GetHats());
        }

        
        public IActionResult HatView(int id)
        {
            Hat HatView = _Hat.FindHat(id);

            return View(HatView);
        }

        public IActionResult Privacy()
        {
            return View();
        }

   
    }
}
