using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Helpers.ModelsDto;
using Xunit;

namespace VotingApp_RESTAPI.Tests
{

    public class VotingServiceTests
    {
        [Fact]
        public async Task TestGetVoteres()
        {
            var factory = new WebApplicationFactory<Startup>();
            var client = factory.CreateClient();
            var result = await client.GetAsync("Voter/Voters");
            Assert.Equal(System.Net.HttpStatusCode.OK, result.StatusCode);
            var content = result.Content;
            var data = await content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<List<VoterDto>>(data);
            Assert.NotNull(model);
        }
    }
}
