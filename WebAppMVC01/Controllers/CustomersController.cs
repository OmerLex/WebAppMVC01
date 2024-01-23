using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using WebAppMVC01.Data;
using WebAppMVC01.Models;

namespace WebAppMVC01.Controllers
{
    public class CustomersController : Controller
    {
        private readonly WebAppMVC01Context _context;

        public CustomersController(WebAppMVC01Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Customer> Customers = _context.Customers.ToList();
            return View(Customers);
        }

        //CREATE
        //Get: Customers/Create
        public IActionResult Create()
        {            
            return View();
        }


        [HttpPost]
        public IActionResult Create([Bind("Id,FirstName,LastName,SSN")] Customer customer) 
        { 
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));        
        }

        public IActionResult Details(int? id)
        {
            Customer customer = _context.Customers.FirstOrDefault(x => x.Id == id);
            return View(customer);
        }

        //EDIT
        public IActionResult Edit(int? id) 
        {
            Customer customer = _context.Customers.FirstOrDefault(x => x.Id == id);
            return View(customer);        
        }

        [HttpPost]
        public IActionResult Edit([Bind("Id,FirstName,LastName,SSN")] Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        //DELETE
        public IActionResult Delete(int? id)
        {
            Customer Customer = _context.Customers.FirstOrDefault(x => x.Id == id);
            return View(Customer);
        }

        [HttpPost]
        public IActionResult Delete([Bind("Id,FirstName,LastName,SSN")] Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


    }
}
