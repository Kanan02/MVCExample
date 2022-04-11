using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;
using MVC.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IToDoService _toDoService;

        public HomeController(ILogger<HomeController> logger,IToDoService toDoService)
        {
            _logger = logger;
            _toDoService = toDoService;

        }
        [HttpGet]
        public IActionResult Index()
        {
            //ViewData["name"] = "Kanan";
            //ViewBag.C = new CounterViewModel()
            //{
            //    Counter = 10
            //};
            return View(_toDoService.toDoValues);
          //  return RedirectToAction("results","home",new {count=700});
        }
        [HttpPost]
        public IActionResult Index(ToDoValue model)
        {
            _toDoService.AddToDo(model);
            return View(_toDoService.toDoValues);
            //  return RedirectToAction("results","home",new {count=700});
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _toDoService.toDoValues.RemoveAt(id);

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Results(int count)
        {
            CounterViewModel model = new CounterViewModel()
            {
                Counter = count
            };
            return Ok(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
