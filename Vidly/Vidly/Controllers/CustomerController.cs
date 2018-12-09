using System;
using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController()
        {
            _context=new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var customers = _context.Customer.Include(c=>c.MembershipType).ToList();
            return customers.Any() ? View(customers) : (ActionResult)HttpNotFound();
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customer.Include(c => c.MembershipType).AsEnumerable().SingleOrDefault(c => c.Id == id);
            return customer != null ? (ActionResult)View(customer):HttpNotFound();
        }

        public ActionResult New()
        {
            return View();
        }
    }
}