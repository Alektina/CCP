using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCDog.Models;

namespace MVCDog.Controllers
{
    public class DogsController : Controller
    {
        private readonly ApplicationContext Context;

        public DogsController(ApplicationContext _context)
        {
            Context = _context;
        }
        public IActionResult Index(int id)
        {
            Dog CurrentDog = new Dog();
            CurrentDog = Context.Dogs.Where(x => x.Id == id).FirstOrDefault();
            return View(CurrentDog);
        }

        public IActionResult CreateDog(int id)
        {
            Breeder CurrentBreeder = Context.Breeders.Include(p => p.Dogs).Where(x => x.Id == id).FirstOrDefault();
            return View(CurrentBreeder);

        }
        public IActionResult Details(int id)
        {
            Dog CurrentDog = new Dog();
            CurrentDog = Context.Dogs.Where(x => x.Id == id).FirstOrDefault();
            return View(CurrentDog);
        }
    }
}