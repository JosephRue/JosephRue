using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JosephRueResume.ViewModels;
using Microsoft.EntityFrameworkCore;
using JosephRueResume.Data;

namespace JosephRueResume.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Resume Resume = new Resume();
            Resume.ID = 0;
            Resume.ContactInfo = _context.ContactInfo.ToList();
            Resume.jobs = _context.jobs.ToList();
            Resume.References =  _context.References.ToList();
            










            return View(Resume);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
