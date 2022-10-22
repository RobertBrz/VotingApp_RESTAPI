using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.Models.Interfaces;

namespace VotingApp_RESTAPI.DBContexts
{
    public class ApplicationDbContext : DbContext
    {

        public readonly IConfiguration Configuration;
        public ApplicationDbContext(IConfiguration configuration) : base()
        {
            Configuration = configuration;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("LocalConnection"));
            }
        }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Voter> Voters { get; set; }
    }
}
