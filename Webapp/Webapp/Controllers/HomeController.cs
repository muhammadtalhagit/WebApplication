using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Webapp.Models;

namespace Webapp.Controllers
{
    public class HomeController : Controller
    {
         

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

		public IActionResult Shop()
		{
			return View();
		}

		public IActionResult Services()
		{
			return View();
		}

		public IActionResult Blog()
		{
			return View();
		}

		public IActionResult Contact()
		{
			return View();
		}
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }

		public IActionResult thankyou()
		{
			return View();
		}
	}
}
