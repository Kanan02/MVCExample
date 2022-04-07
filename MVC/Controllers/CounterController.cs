using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Services.Abstract;

namespace MVC.Controllers
{
    //сначала ищет по названию потом по наследованию потом по фильтру []
    [Controller]
 //   [Route("[controller]/[action]")]
    [Area("My")]
    public class CounterController:Controller
    {
        private readonly ICounterService _counter;
        public CounterController(ICounterService counter)
        {
            _counter=counter;
        }
 //       [ActionName("Visits")]
     //   [Route("[controller]/[action]")]

        public IActionResult Index(User user)
        {
            return View(user);
            //   return user.Name+" "+user.Surname;
        }
        public IActionResult Show(User user)
        {
            //return View(new CounterViewModel()
            //{
            //    Counter = int.Parse(count)
            //});
            return View(user);
        }
        public string Index2()
        {
            return "Losos";
            //   return user.Name+" "+user.Surname;
        }

    }
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
