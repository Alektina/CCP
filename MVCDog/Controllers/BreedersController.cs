using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCDog;
using MVCDog.Models;

namespace MVCDog.Controllers
{
    public class BreedersController : Controller
    {
        private readonly ApplicationContext _context;

        public BreedersController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Breeders
        public async Task<IActionResult> Index()
        {
              return _context.Breeders != null ? 
                          View(await _context.Breeders.ToListAsync()) :
                          Problem("Entity set 'ApplicationContext.Breeders'  is null.");
        }

        // GET: Breeders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Breeders == null)
            {
                return NotFound();
            }

            var breeder = await _context.Breeders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (breeder == null)
            {
                return NotFound();
            }

            return View(breeder);
        }

        // GET: Breeders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Breeders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,DogId,ContactId,KennelId")] Breeder breeder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(breeder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(breeder);
        }

        // GET: Breeders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Breeders == null)
            {
                return NotFound();
            }

            var breeder = await _context.Breeders.FindAsync(id);
            if (breeder == null)
            {
                return NotFound();
            }
            return View(breeder);
        }

        // POST: Breeders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,DogId,ContactId,KennelId")] Breeder breeder)
        {
            if (id != breeder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(breeder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BreederExists(breeder.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(breeder);
        }

        // GET: Breeders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Breeders == null)
            {
                return NotFound();
            }

            var breeder = await _context.Breeders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (breeder == null)
            {
                return NotFound();
            }

            return View(breeder);
        }

        // POST: Breeders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Breeders == null)
            {
                return Problem("Entity set 'ApplicationContext.Breeders'  is null.");
            }
            var breeder = await _context.Breeders.FindAsync(id);
            if (breeder != null)
            {
                _context.Breeders.Remove(breeder);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BreederExists(int id)
        {
          return (_context.Breeders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
