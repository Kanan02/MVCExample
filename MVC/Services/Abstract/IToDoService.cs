using MVC.Models;
using System.Collections.Generic;

namespace MVC.Services.Abstract
{
    public interface IToDoService
    {
        public void AddToDo(ToDoValue doValue);
        public List<ToDoValue> toDoValues { get; set; }
    }
}
