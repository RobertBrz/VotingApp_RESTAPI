using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using VotingApp.Shared.CustomExceptions;

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
            catch (CandidateNotFoundException)
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync("Candidate not exist in database");
            }
            catch (VoterNotFoundException)
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync("Voter not exist in database");
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync("Duplicated Pesel Error");
            }
            catch (Exception ex)
            {
                await context.Response.WriteAsync(ex.ToString());   
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("Not registered error occured");
            }
        }
    }
}
