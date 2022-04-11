using MVC.Models;
using MVC.Services.Abstract;
using System.Collections.Generic;

namespace MVC.Services.Concrete
{
    public class ToDoService : IToDoService
    {
       
        public List<ToDoValue> toDoValues { get; set; } = new List<ToDoValue>()
        {

        };
        public void AddToDo(ToDoValue doValue)
        {
            toDoValues.Add(doValue);
           
        }
    }
}
