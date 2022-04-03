using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Services.Abstract;

namespace MVC.Controllers
{

    public class CounterController : Controller
    {
        private readonly ICounterService _counter;
        public CounterController(ICounterService counter)
        {
            _counter=counter;
        }
        public IActionResult Index()
        {
            return View(new CounterViewModel()
            {
                Counter = _counter.C
            });
        }
    }
}
