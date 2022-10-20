using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.Services.Interfaces;

namespace VotingApp_RESTAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoterController : ControllerBase
    {
        private readonly IVoterService _voterService;
        private readonly ILogger<VoterController> _logger;

        public VoterController(ILogger<VoterController> logger, IVoterService voterService)
        {
            _voterService = voterService;
            _logger = logger;
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddVoter([FromBody] Voter voter)
        {
            _voterService.AddVoter(voter);
            return Ok();
        }

        [HttpGet]
        [Route("Voters")]
        public IActionResult GetVoters()
        {
            _voterService.GetVoters();
            return Ok();
        }

        [HttpGet]
        [Route("Voters/{voterID}")]
        public IActionResult GetVoter([FromRoute] int voterID)
        {
            var result = _voterService.GetVoter(voterID);
            return Ok(result);
        }

        [HttpPost]
        [Route("Vote/{voterID}")]
        public IActionResult Vote([FromBody] Candidate candidate, [FromRoute] int voterID)
        {
            _voterService.Vote(candidate, voterID);
            return Ok();
        }
    }
}
