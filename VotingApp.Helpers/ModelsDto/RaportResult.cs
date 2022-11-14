using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Shared.ModelsDto
{
    public class RaportResult
    {
        JObject JsonRaport { get; set; }

        public RaportResult(List<CandidateDto> candidates)
        {
            JsonRaport = JObject.FromObject(candidates);
        }
    }
}
