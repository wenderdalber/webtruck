using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var repository = new RepositoryTruck();
            var model = repository.GetAll();

            return View(model);
        }

        public IActionResult AddTruck()
        {
            return View();
        }

        public IActionResult Edit(int truck)
        {
            var repository = new RepositoryTruck();
            var model = repository.Get(truck);

            return View(model);
        }

        public IActionResult EditTruck(int truck, int yearmodel, int yearmanufacturing, int model)
        {
            var repository = new RepositoryTruck();
            var retorno = repository.Update(truck, yearmodel, yearmanufacturing, model);

            TempData["Message"] = "Alterado com sucesso!";
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Add(int yearmodel, string yearmanufacturing, int model)
        {
            var repository = new RepositoryTruck();
            var retorno = repository.Add(yearmodel, yearmanufacturing, model);

            TempData["Message"] = "Adicionado com sucesso!";

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int truck)
        {
            var repository = new RepositoryTruck();
            var retorno = repository.Delete(truck);

            TempData["Message"] = "Removido com sucesso!";

            return RedirectToAction("Index", "Home");
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
