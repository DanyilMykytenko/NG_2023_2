using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebAuthApp.Middlewares
{
   
    public class Middleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<Middleware> _logger;

        public Middleware(RequestDelegate next, ILogger<Middleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "An error has ocured");
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                var errorResponse = new ErrorResponse { Message = "An eror has ocured" };
                await JsonSerializer.SerializeAsync(context.Response.Body, errorResponse);
            }
        }
        public class ErrorResponse
        {
            public string Message { get; set; }
        }
    }
}
