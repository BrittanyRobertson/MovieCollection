using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieCollection.Models;

namespace MovieCollection.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext blahContext { get; set; }

        public HomeController(MovieContext someName)
        {
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = blahContext.Categories.ToList();
            ViewBag.Method = "add";

            return View();
        }

        [HttpPost]
        public IActionResult Movies(ApplicationResponse ar)
        {
            ViewBag.Categories = blahContext.Categories.ToList();

            if (ModelState.IsValid)
            {
                blahContext.Add(ar);
                blahContext.SaveChanges();

                return RedirectToAction("MovieList");
            }
            else //if invalid
            { 

                return View();
            }
        }

        public IActionResult MyPodcasts()
        {
            return Redirect("https://baconsale.com/");
        }

        public IActionResult MovieList()
        {
            var movies = blahContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int applicationid)
        {
            ViewBag.Categories = blahContext.Categories.ToList();
            ViewBag.Method = "edit";

            var movie = blahContext.Responses.Single(x => x.MovieId == applicationid);

            return View("Movies", movie);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse ar)
        {
            blahContext.Update(ar);
            blahContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var movie = blahContext.Responses.Single(x => x.MovieId == applicationid);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            blahContext.Responses.Remove(ar);
            blahContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}

//ApplicationResponse OldMov = blahContext.Responses.Find(ar.MovieId);
//blahContext.Responses.Remove(OldMov);
//blahContext.Responses.Add(ar);
//blahContext.SaveChanges();

