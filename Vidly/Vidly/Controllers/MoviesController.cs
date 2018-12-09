using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context=new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m=>m.Genre).ToList();
           return View(movies);
        }

        public ActionResult Details(int id)
        {
            return View(_context.Movies.Include(m => m.Genre).AsEnumerable().SingleOrDefault(m => m.Id == id));
        }
        
    }
}