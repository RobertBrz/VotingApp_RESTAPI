using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.RestAdapter
{
    [ApiController]
    [Route("api/New")]
    public class NewController : ControllerBase
    {

        [HttpGet]
        public  IActionResult Get()
        {
            return Ok();
        }
    }
}
