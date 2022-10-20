using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VotingApp_RESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetCandidates()
        {
            return Ok();
        }


    }
}
