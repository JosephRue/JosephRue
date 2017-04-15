using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JosephRueResume.Data;
using JosephRueResume.Models;

namespace JosephRueResume.Controllers
{
    public class jobsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public jobsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: jobs
        public async Task<IActionResult> Index()
        {
            return View(await _context.jobs.ToListAsync());
        }

        // GET: jobs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobs = await _context.jobs.SingleOrDefaultAsync(m => m.ID == id);
            if (jobs == null)
            {
                return NotFound();
            }

            return View(jobs);
        }

        // GET: jobs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: jobs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CompanyName,EndDate,StartDate,jobTitle")] jobs jobs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobs);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(jobs);
        }

        // GET: jobs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobs = await _context.jobs.SingleOrDefaultAsync(m => m.ID == id);
            if (jobs == null)
            {
                return NotFound();
            }
            return View(jobs);
        }

        // POST: jobs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CompanyName,EndDate,StartDate,jobTitle")] jobs jobs)
        {
            if (id != jobs.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!jobsExists(jobs.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(jobs);
        }

        // GET: jobs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobs = await _context.jobs.SingleOrDefaultAsync(m => m.ID == id);
            if (jobs == null)
            {
                return NotFound();
            }

            return View(jobs);
        }

        // POST: jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobs = await _context.jobs.SingleOrDefaultAsync(m => m.ID == id);
            _context.jobs.Remove(jobs);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool jobsExists(int id)
        {
            return _context.jobs.Any(e => e.ID == id);
        }
    }
}
