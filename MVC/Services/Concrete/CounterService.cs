using MVC.Services.Abstract;

namespace MVC.Services
{
    public class CounterService:ICounterService
    {
        public int C { get; set; } = 0;
    }
}
