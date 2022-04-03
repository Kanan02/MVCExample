using Microsoft.AspNetCore.Http;
using MVC.Services.Abstract;
using System.Threading.Tasks;

namespace MVC.Middlewares
{
    public class CounterMiddleware
    {
        private readonly RequestDelegate _next;

        public CounterMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context,ICounterService counter)
        {
            if (context.Request.Path.Value != null && !context.Request.Path.Value.StartsWith("/favicon.ico"))
            {
                counter.C++;
            }
            // Call the next delegate/middleware in the pipeline.
            await _next(context);
        }
    }
}
