using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data.Entity;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly_1._0.Dtos;
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
        // GET /api/customers  -- this is the convention build into asp.net web api

        public IHttpActionResult GetCustomers()  // Create an action for get customers
        {
            /*   return _context.Customers.ToList().Select(Mapper.Map<Customer,CustomerDto>);  in select pass the delegate that does the mapping
             in map<> specify the source and target types  */

            var customerDtos = _context.Customers.
                Include(c=> c.MembershipType)
                .ToList()
                .Select(Mapper.Map<Customer, CustomerDto>);

            return Ok(customerDtos);
        }

        // GET /api/customers/1  -- get a customer
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return Ok(Mapper.Map<Customer,CustomerDto>(customer)); /* here only return 1 customer object
            so can't use select(). so use this.  */
            
        }

        // POST api/customers
        [HttpPost] // this action will only be called when there is a post request. 
        public IHttpActionResult CreateCustomer(CustomerDto customerDto) // this customer object in the request body,
                                                          // asp.net web api framework will automatically initialize this.
        {
            if (!ModelState.IsValid)
                //   throw  new HttpResponseException(HttpStatusCode.BadRequest);
                return BadRequest(); // with the use of IHttpActionResult do not need to use exception

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();
            // here need to map dto back to domain object.

            customerDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto); // here as a part of restful convention,
                              // need to return uri of the newly created resources of the client
            // get the uri of current request and append the new id.
        }

        // PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();

            Mapper.Map(customerDto,customerInDb); // if we have an existing object, pass that here as a second argument.
                                                  // previous create a new object and returned it.
            //  var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
         /*   customerInDb.Name = customerDto.Name;
            customerInDb.Birthdate = customerDto.Birthdate;
            customerInDb.IsSubscribedToNewsLetter = customerDto.IsSubscribedToNewsLetter;
            customerInDb.MembershipTypeId = customerDto.MembershipTypeId;
           no need of these attributes */
            _context.SaveChanges();

            // using auto mapper we don't want to explicitly set each properties of customer here.

            return Ok();
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();

            return Ok();
        }

        }
    }

