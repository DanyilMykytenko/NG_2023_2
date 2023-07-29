using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters.Filters
{
    public class LogginFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.RouteData.Values["controller"];
            var action = context.RouteData.Values["action"];
            Console.WriteLine($"Executing {controller}/{action}");
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var controller = context.RouteData.Values["controller"];
            var action = context.RouteData.Values["action"];
            Console.WriteLine($"Executing {controller}/{action}");
        }
    }
}
