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
    public class DogsController : Controller
    {
        private readonly ApplicationContext _context;

        public DogsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Dogs
        public async Task<IActionResult> Index()
        {
            var dogs = _context.Dogs.ToList();

            // Create a dictionary to store country names using the CountryID as the key
            var countryNames = _context.Countries.ToDictionary(c => c.CountryID, c => c.CountryName);

            // Pass the list of dogs and the country names to the view
            ViewData["CountryNames"] = countryNames;

            return _context.Dogs != null ? 
                          View(await _context.Dogs.ToListAsync()) :
                          Problem("Entity set 'ApplicationContext.Dogs'  is null.");
        }

        // GET: Dogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Dogs == null)
            {
                return NotFound();
            }

            var dog = await _context.Dogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dog == null)
            {
                return NotFound();
            }

            return View(dog);
        }

        // GET: Dogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Nickname,Reg_number,Birth_date,Sex,Color,Weight,Height,Hairlayers,TitleId,DogId_Mother,DogId_Father,Death_date,Other_info")] Dog dog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dog);
        }

        // GET: Dogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Dogs == null)
            {
                return NotFound();
            }

            var dog = await _context.Dogs.FindAsync(id);
            if (dog == null)
            {
                return NotFound();
            }
            // Fetch a list of countries for the dropdown
            var countries = await _context.Countries.ToListAsync();

            // Create a list of SelectListItem for the dropdown
            var countryList = countries.Select(c => new SelectListItem
            {
                Text = c.CountryName,
                Value = c.CountryID.ToString()
            }).ToList();

            // Set the selected country for the dog
            var selectedCountry = dog.CountryID.ToString();

            // Create a SelectList for the dropdown with the selected value
            ViewData["Countries"] = new SelectList(countryList, "Value", "Text", selectedCountry);

            return View(dog);
        }

        // POST: Dogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Nickname,Reg_number,Birth_date,Sex,Color,Weight,Height,Hairlayers,TitleId,DogId_Mother,DogId_Father,Death_date,Other_info")] Dog dog)
        {
            if (id != dog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DogExists(dog.Id))
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
            return View(dog);
        }

        // GET: Dogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Dogs == null)
            {
                return NotFound();
            }

            var dog = await _context.Dogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dog == null)
            {
                return NotFound();
            }

            return View(dog);
        }

        // POST: Dogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Dogs == null)
            {
                return Problem("Entity set 'ApplicationContext.Dogs'  is null.");
            }
            var dog = await _context.Dogs.FindAsync(id);
            if (dog != null)
            {
                _context.Dogs.Remove(dog);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DogExists(int id)
        {
          return (_context.Dogs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
