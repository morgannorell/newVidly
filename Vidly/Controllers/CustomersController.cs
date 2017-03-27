using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {            
            var customers = CustomerList();

            return View(customers);
        }

        // Return one customer
        public ActionResult Details(int id)
        {
            var customer = CustomerList().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer); 
        }

        // List of Customers
        private IEnumerable<Customer> CustomerList()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Morgan Norell" },
                new Customer { Id = 2, Name = "Therese Sallander" }
            };
        }
    }
}