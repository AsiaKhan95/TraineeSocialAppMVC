using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraineeSocialAppMVC.UOW;

namespace TraineeSocialAppMVC.Controllers
{
    public class CityController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CityController> _logger;
        // GET: CityController
        public CityController(IUnitOfWork unitOfWork, ILogger<CityController> logger) {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<City> cities = _unitOfWork.Cities.GetAll();
         //   _unitOfWork.Cities = null;
            return View(cities);
        }

        // GET: CityController/Details/5
      /*  public ActionResult Details(int id)
        {
            return View();
        }*/

        // GET: CityController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CityController/Edit/5
       /* public ActionResult Edit(int id)
        {
            return View();
        }*/

        // POST: CityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CityController/Delete/5
      /*  public ActionResult Delete(int id)
        {
            return View();
        }*/

        // POST: CityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
