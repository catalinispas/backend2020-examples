using Lesson01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lesson01.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public IActionResult Index()
        {
            ViewData["movie"] = "One Flew Over the Cuckoo's Nest";
            ViewData["year"] = 1975;

            ViewBag.Movie = "Forrest Gump";
            ViewBag.Year = 1994;

            return View(new Movie { Title = "Intouchables", Year = 2011 });
        }
   
        // GET: Movie
        public IActionResult Example01()
        {
            ViewBag.Movie = "One Flew Over the Cuckoo's Nest";
            ViewBag.Year = 1975;

            return View();
        }
    }
}