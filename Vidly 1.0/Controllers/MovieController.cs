using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_1._0.Models;

namespace Vidly_1._0.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {

            var movies = GetMovies();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            else
            {
                return View(movie);
            }
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id = 1,Name = "Shrek"},
                new Movie{Id = 2,Name = "Ice Age"}
            };
        }
    }
}