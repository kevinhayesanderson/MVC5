using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModal;

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
            var membershipsTypes = _context.MembershipTypes.ToList();
            var customer=new Customer();
            var viewModal = new CustomerViewModal()
            {
                MembershipTypes = membershipsTypes,
                Customer = customer
            };
            return View("CustomerForm", viewModal);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (customer.Id != 0)
            {
                var customerInDb = _context.Customer.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            }
            else
            {
                _context.Customer.Add(customer);
            }
            _context.SaveChanges();
           return RedirectToAction("Index","Customer");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customer.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            var viewModal=new CustomerViewModal()
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm", viewModal);
        }
    }
}