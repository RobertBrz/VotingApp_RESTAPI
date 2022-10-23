using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp_RESTAPI.ModelsDto;
using Xunit;

namespace VotingApp_RESTAPI.Tests
{
    public class CandidateServiceTest
    {
        [Fact]
        public async Task TestGetCandidates()
        {
            var factory = new WebApplicationFactory<Startup>();
            var client = factory.CreateClient();
            var result = await client.GetAsync("Candidate/GetAll");
            Assert.Equal(System.Net.HttpStatusCode.OK, result.StatusCode);
            var content = result.Content;
            var data = await content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<List<CandidateDto>>(data);
            Assert.NotNull(model);
        }
    }
}
