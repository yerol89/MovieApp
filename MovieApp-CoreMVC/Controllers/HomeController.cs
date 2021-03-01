using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApp_CoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp_CoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? id)
        {
            var movie = new Movie();
            var myList = movie.GetAllMovies();
            if (id != null)
            {
                myList = myList.Where(x => x.CategoryId == id).ToList();
                if (myList.Count == 0)
                {
                    ViewBag.Message = "NO MOVIE IN THIS CATEGORY";
                }
                return View(myList);
            }
           
            
            return View(myList);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var movie = new Movie();
            var myMovie = movie.GetById(id);
            return View(myMovie);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
