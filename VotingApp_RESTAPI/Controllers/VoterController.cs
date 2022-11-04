using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingApp_RESTAPI.DBContexts;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.ModelsDto;
using VotingApp_RESTAPI.Services.Interfaces;

namespace VotingApp_RESTAPI.Controllers
{
    [ApiController]
    [Route("Voter")]
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
        public IActionResult AddVoter([FromBody] VoterDto voter)
        {
            _voterService.AddVoter(voter);
            return Ok();
        }

        [HttpGet]
        [Route("Voters")]
        public IActionResult GetVoters()
        {
            return Ok(_voterService.GetVoters());
        }

        [HttpGet]
        [Route("Voters/{voterid}")]
        public IActionResult GetVoter([FromRoute] int voterid)
        {
            return Ok(_voterService.GetVoter(voterid));
        }

        [HttpPost]
        [Route("Vote/{voterid}")]
        public IActionResult Vote([FromQuery] int candidateid, [FromRoute] int voterid)
        {
            _voterService.Vote(candidateid, voterid);
            return Ok();
        }
    }
}
