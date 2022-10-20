using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using VotingApp_RESTAPI.CustomExceptions;

namespace VotingApp_RESTAPI
{
    
    public class ErrorHandlingMiddleware:IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next.Invoke(context);
            }
            catch (CustomException ex)
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync("custom exception");
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("Something went wrong");
            }
        }
    }
}
