using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using VotingApp.Shared.ModelsDto;
using VotingApp.Voters.Domain.Models.Voter;
using VotingApp.Voters.Domain.Services.Interfaces;

namespace VotingApp.Voters.Application
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
            _voterService.AddVoter(voter.Name, voter.Pesel);
            return Ok(voter);
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
        [Route("Vote")]
        public IActionResult Vote([FromBody] VoteDto voteDto)
        {
            return Ok(_voterService.Vote(voteDto));
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult UpdateVoter([FromBody] VoterDto voter)
        {
            return Ok(_voterService.UpdateVoter( voter));
        }
    }
}
