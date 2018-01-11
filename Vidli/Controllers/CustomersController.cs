using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidli.Models;
using Vidli.ViewModels;

namespace Vidli.Controllers
{
    public class CustomersController : Controller
    {
        //for db access we need to declare a db context
        private ApplicationDbContext _context;
        //initialize dbContext in constructor
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //dbcontext is a dispossable object, so we need to dipose it
        //proper way to do it: override dispose mehtod of base controller class
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //action for form : 
        public ActionResult New()
        {
            var membershiptTypes = _context.MembershipTypes.ToList();
            //**in the case when we need to send several var from view we need to use a viewModel like here NewCustomerViewModel
            //inittalize newCustomerViewModel using object intilizer
            var viewModel = new NewCustomerViewModel {MembershipTypes = membershiptTypes};

            return View(viewModel);
        }

        //action for receive form data
        [HttpPost]
        public ActionResult
            Create(Customer customer) //MVC will automatically map request data to this obj which is model binding
        {
            //first we need to add it to context to add to db, however it will not add to db rather in memory
            _context.Customers.Add(customer);
            //dbcontext as change tracking mechnism any time we add/modify/delete
            //second: to persist this changes we need to 
            _context.SaveChanges();
            //redirect to customer list which is index in customer controller
            return RedirectToAction("Index", "Customers");
        }

        // GET: Customers
        public ActionResult Index()
        {
            //assigned context to customers object which is a DbSet
            //now the query will be executed when we iterate thru customers object or we can do it by adding ToList()
            //also included Eager loading for membershipType
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            //using context with SingleOrDefault for getting one single customer
            //also included Eager loading for membershipType
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        //public IEnumerable<Customer> GetCustomers()
        //{
        //    List<Customer> customers = new List<Customer>
        //    {
        //        new Customer{Id = 1, Name = "John Smith"},
        //        new Customer{Id = 2, Name = "Marry Williams"},

        //    };

        //    return customers;
        //}
    }
}