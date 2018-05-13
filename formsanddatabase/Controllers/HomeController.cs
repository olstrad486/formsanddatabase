using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace formsanddatabase.Controllers
{
    public class HomeController : Controller
    {
        private readonly ContactFormsContext _context;

        public HomeController(ContactFormsContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactForm contact)
        {
            
            _context.ContactForms.Add(contact);
            _context.SaveChanges();
            
            return View();
        }
    }

}