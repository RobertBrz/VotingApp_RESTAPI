using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Domain.Channels;
using VotingApp.Domain.Requests;
using VotingApp.Shared.ModelsDto;

namespace VotingApp.Application
{
    [ApiController]
    [Route("api/Raport")]
    public class RaportController : ControllerBase
    {
        RaportChannel _raportChannel;

        public RaportController(RaportChannel raportChannel)
        {
            _raportChannel = raportChannel;
        }

        [HttpPost]
        [Route("Generate")]
        public IActionResult Get([FromQuery] DateTime startTime, DateTime endTime)
        {
            _raportChannel.PubicAsync(new RaportRequest(startTime, endTime));
            return Ok();
        }
    }
}
