using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Domain.Models;

namespace VotingApp.DAL.Models
{
    public class RaportResult
    {
        JObject JsonRaport { get; set; }

        public RaportResult(List<Candidate> candidates)
        {
            JsonRaport = JObject.FromObject(candidates);
        }
    }
}
