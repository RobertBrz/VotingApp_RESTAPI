using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using VotingApp_RESTAPI.CustomExceptions;

namespace VotingApp_RESTAPI
{

    public class ErrorHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next.Invoke(context);
            }
            catch (CandidateNotFoundException ex)
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync("Candidate not exist in database");
            }
            catch (NoVoterFoundException ex)
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync("Voter not exist in database");
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("Not registered error occured");
            }
        }
    }
}
