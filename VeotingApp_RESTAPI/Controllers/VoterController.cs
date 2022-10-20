using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingApp_RESTAPI.Model;

namespace VotingApp_RESTAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoterController : ControllerBase
    {

        private readonly ILogger<VoterController> _logger;

        public VoterController(ILogger<VoterController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("AddVoter")]
        public IActionResult AddVoter([FromBody] Voter voter)
        {

            return Ok();
        }


        [HttpGet]
        [Route("GetVoter/{name}")]
        public IActionResult GetVoter(string name)
        {
            return Ok();
        }
    }
}
