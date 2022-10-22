using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingApp_RESTAPI.DBContexts;
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

        public VoterController(ILogger<VoterController> logger,
            IVoterService voterService
                  )
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
        public IActionResult GetVoter([FromRoute] long pesel)
        {
            var result = _voterService.GetVoter(pesel);
            return Ok(result);
        }

        [HttpPost]
        [Route("Vote/{voterID}")]
        public IActionResult Vote([FromBody] Candidate candidate, [FromRoute] string pesel)
        {
            _voterService.Vote(candidate, pesel);
            return Ok();
        }
    }
}
