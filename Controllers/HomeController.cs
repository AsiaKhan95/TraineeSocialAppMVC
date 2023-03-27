using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using System.Diagnostics;
using TraineeSocialAppMVC.Models;

namespace TraineeSocialAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly SocialAppDBContext _context;
        private readonly IRepository<User> UserRepository;
        public HomeController(ILogger<HomeController> logger, SocialAppDBContext context)
        {
            _logger = logger;
          //  this._context = context;
            UserRepository = new Repository<User>(context);
        }
        public IActionResult Index()
        {
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