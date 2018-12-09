using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private readonly List<Customer> _customers = new List<Customer>()
        {
            new Customer(){Name = "Kevin",Id = 1},
            new Customer(){Name = "Hayes",Id = 2},
            new Customer(){Name = "Anderson",Id = 3},
        };
        // GET: Customer
        public ActionResult Index()
        {
            
            return View(_customers);
        }

        public ActionResult Details(int id)
        {
            return View(_customers[id-1]);
        }
    }
}