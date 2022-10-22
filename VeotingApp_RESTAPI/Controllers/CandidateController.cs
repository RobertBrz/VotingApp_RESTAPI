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
    [Route("api/[controller]")]
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
            var candidates = _candidateService.GetCandidates();
            return Ok(candidates);
        }

        [HttpGet]
        [Route("{candidateID}")]
        public IActionResult GetCandidate([FromRoute] int candidateID)
        {
            return Ok();
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddCandidate(Candidate candidate)
        {
            return Ok();
        }
    }
}
