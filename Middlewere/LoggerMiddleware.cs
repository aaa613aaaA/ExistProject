using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Middlewere
{
 
    public class LoggerMiddleware 
    {
        private readonly RequestDelegate next;

        public LoggerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public  async Task InvokeAsync(HttpContext httpContext, ILogger<LoggerMiddleware> logger)
        {

            logger.LogInformation($"{httpContext.Request.Path} request started");

             await next(httpContext);

            logger.LogInformation($"{httpContext.Request.Path} request ended");

        }
    }
}
