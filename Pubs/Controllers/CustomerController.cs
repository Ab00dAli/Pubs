using Microsoft.AspNetCore.Mvc;
using Pubs.Data;
using Pubs.Models;

namespace Pubs.Controllers
{
    public class CustomerController : Controller
    {
        private readonly PubsDbContext _context;
        public CustomerController(PubsDbContext context)
        {
            _context= context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Customer> customers = _context.Customers.ToList();
            return View(customers);
        }
        [HttpGet]
        public IActionResult Details(int id) 
        {
            Customer? customer= _context.Customers.SingleOrDefault(x => x.Id == id);
            
            if (customer == null) return RedirectToAction(nameof(Index));
            
            return View(customer);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if(!ModelState.IsValid) return View(customer);

            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Delete(int id) 
        {
            Customer? customer = _context.Customers.SingleOrDefault(x => x.Id == id);

            if (customer == null) return RedirectToAction(nameof(Index));
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Customer? customer = _context.Customers.SingleOrDefault(x => x.Id == id);

            if (customer == null) return RedirectToAction(nameof(Index));
            return View(customer);
        }

        [HttpPost]
        public IActionResult Update(Customer customer)
        {
            if (!ModelState.IsValid) return View(customer);

            _context.Customers.Update(customer);
            _context.SaveChanges(true);
            return RedirectToAction(nameof(Index));
        }

    }
}
