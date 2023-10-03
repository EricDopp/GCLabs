using CoffeeShopRegistration.Models;
using CoffeeShopRegistration.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegistration.Controllers
{
    public class UserController : Controller
    {
        //Dependency Injection
        private readonly AppDbContext _appDbContext;

        //We are injecting the DbContext into this controller through the constructor
        public UserController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //Index is the Action
        //These are called controller actions
        public IActionResult Index()
        {
            User user = new User();

            return View(user);
        }

        [HttpPost]
        public IActionResult ProcessUserForm([FromForm] User newUser)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

                _appDbContext.Users.Add(newUser);

                //This step is easy to forget
                //This is where it is actually saved to the database. If you don't do this it won't be saved

                _appDbContext.SaveChanges();

                return RedirectToAction("Index", "Home");
        }
    }
}
