using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using E_Shop.Models;

namespace E_Shop.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

        public IActionResult blank()
        {
            return View();
        }

        public IActionResult checkout()
        {
            return View();
        }

        public IActionResult productpage()
        {
            return View();
        }

        public IActionResult products()
        {
            return View();
        }


    }
}
