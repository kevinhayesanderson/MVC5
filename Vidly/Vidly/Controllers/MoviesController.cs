using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly List<Movie> _movies=new List<Movie>()
        {
            new Movie(){Id = 1,Name="Shrek"},
            new Movie(){Id = 2,Name="Atlas"},
            new Movie(){Id = 3,Name="Wanted"}

        };
        // GET: Movies
        public ActionResult Index()
        {
           return View(_movies);
        }

        public ActionResult Details(int id)
        {
            return View(_movies[id - 1]);
        }
        
    }
}