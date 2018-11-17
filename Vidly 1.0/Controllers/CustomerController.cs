using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_1._0.Models;

namespace Vidly_1._0.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.Customers.Include( c=> c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
                return View(customer);
        }
      

        
    }
}