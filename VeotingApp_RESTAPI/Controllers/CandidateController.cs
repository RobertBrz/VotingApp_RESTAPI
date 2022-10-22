using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using VotingApp_RESTAPI.DBContexts;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.ModelsDto;
using VotingApp_RESTAPI.Services.Interfaces;

namespace VotingApp_RESTAPI.Controllers
{
    [Route("api/Candidate")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService _candidateService;
        private readonly ILogger<VoterController> _logger;
        private readonly IMapper _mapper;

        public CandidateController(ILogger<VoterController> logger,
            ICandidateService candidateService,
            IMapper mapper)
        {
            _candidateService = candidateService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetCandidates()
        {
            return Ok(_candidateService.GetCandidates());
        }

        [HttpGet]
        [Route("{candidateID}")]
        public IActionResult GetCandidate([FromRoute] int candidateID)
        {
            return Ok(_candidateService.GetCandidate(candidateID));
        }

        [HttpPost]
        [Route("AddCandidate")]
        public IActionResult AddCandidate(CandidateDto candidatedto)
        {
            _candidateService.AddCandidate(candidatedto);
            return Ok();
        }
    }
}
