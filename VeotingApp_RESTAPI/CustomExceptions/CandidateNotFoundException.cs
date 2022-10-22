using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace VotingApp_RESTAPI.CustomExceptions
{
   
    public class CandidateNotFoundException :Exception
    {
    }
}
