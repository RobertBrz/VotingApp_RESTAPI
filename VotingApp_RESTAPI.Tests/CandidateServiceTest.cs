using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using VotingApp.DAL.DBContexts;
using VotingApp.Domain.Models;
using VotingApp.Helpers.ModelsDto;
using Xunit;
using Xunit.Sdk;

namespace VotingApp_RESTAPI.Tests
{
    public class CandidateServiceTest
    {
        private IConfiguration _configuration;
        private DbContextOptions<ApplicationDbContext> _options;


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

        [Fact]
        public void TestDuplicatingCandidates()
        {

            var builder = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json");

            _configuration = builder.Build();
            _options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(
                _configuration.
                GetConnectionString("TestConnection"))
                
            .Options;


            using (var context = new ApplicationDbContext(_configuration, _options) )
            {
                var deleted = context.Database.EnsureDeleted();
                var created = context.Database.EnsureCreated();

                var candidate1 = new Candidate()
                {
                    Name = "name1",
                    Pesel = 123,
                };

                context.Candidates.Add(candidate1);
                context.SaveChanges();

                var list = context.Candidates;
                Assert.True(list.Contains(candidate1));

                context.Candidates.Add(candidate1);
                Assert.Throws<DbUpdateException>(() => context.SaveChanges());
            }
        }
    }
}
