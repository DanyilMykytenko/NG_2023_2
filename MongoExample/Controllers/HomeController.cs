using Microsoft.AspNetCore.Mvc;
using MongoExample.Entity.Collections;
using MongoExample.Models;
using MongoExample.Repository;
using System.Diagnostics;

namespace MongoExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMongoRepository<User> _userRepository;

        public HomeController(ILogger<HomeController> logger, IMongoRepository<User> repository)
        {
            _logger = logger;
            _userRepository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var Person = new User()
            {
                UserName = "Vadik",
                LastName = "Mongo",
                Email = "Mongo@email.com"
            };
            await _userRepository.InsertOneAsync(Person);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}