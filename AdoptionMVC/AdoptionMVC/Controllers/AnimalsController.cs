using AdoptionMVC.Models;
using AdoptionMVC.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace AdoptionMVC.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public AnimalsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index(string? searchTerm)
        {
            if(searchTerm != null)
            {
                return View(_appDbContext.Animals.Where(x => x.breed.ToLower().Trim().Contains(searchTerm.ToLower())).ToList());
            }

            List<Animals> animals = _appDbContext.Animals.OrderBy(x => x.breed).ToList();
            return View(animals);
        }
        public IActionResult GetByID(int id) 
        {
            Animals animals = _appDbContext.Animals.FirstOrDefault(x => x.ID == id);

            if(animals == null)
            {
                return NotFound();
            }

            return View(animals);
        }
        public IActionResult adoptAnimal(int id)
        {
            Animals animals = _appDbContext.Animals.FirstOrDefault(x => x.ID == id);

            if(animals == null)
            {
                return NotFound();
            }

            _appDbContext.Animals.Remove(animals);

            _appDbContext.SaveChanges();

            return RedirectToAction("Index", "Animals");
        }
        [HttpPost]
        public IActionResult addAnimal([FromForm] Animals newAnimal)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            _appDbContext.Animals.Add(newAnimal);

            _appDbContext.SaveChanges();

            return RedirectToAction("Index", "Animals");
        }
    }
}
