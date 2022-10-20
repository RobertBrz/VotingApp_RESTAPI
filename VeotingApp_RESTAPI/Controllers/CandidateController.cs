using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.Services.Interfaces;

namespace VotingApp_RESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService _candidateService;
        private readonly ILogger<VoterController> _logger;

        public CandidateController(ILogger<VoterController> logger, ICandidateService candidateService)
        {
            _candidateService = candidateService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetCandidates()
        {
            _candidateService.GetCandidates();
            return Ok();
        }

        [HttpGet]
        [Route("{candidateID}")]
        public IActionResult GetCandidate([FromRoute] int candidateID)
        {
            return Ok();
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddCandidate(ICandidate candidate)
        {
            return Ok();
        }
    }
}
