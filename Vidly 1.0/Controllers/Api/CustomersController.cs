using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly_1._0.Models;

namespace Vidly_1._0.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET /api/customers

        public IEnumerable<Customer> GetCustomers()  // Create an 
        {
            return _context.Customers.ToList();
        }
    }
}
