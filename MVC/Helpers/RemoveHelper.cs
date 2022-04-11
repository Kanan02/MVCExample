using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Models;
using System.Collections.Generic;

namespace MVC.Helpers
{
    public static class RemoveHelper
    {
        public static HtmlString Remove(this IHtmlHelper html,List<ToDoValue> toDoValues)
        {
            if (toDoValues.Count>0)
            {
                toDoValues.RemoveAt(0);
            }
            return new HtmlString("");
        }
    }
}
