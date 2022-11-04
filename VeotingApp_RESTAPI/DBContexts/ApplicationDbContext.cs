using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VotingApp_RESTAPI.Models;

namespace VotingApp_RESTAPI.DBContexts
{
    public class ApplicationDbContext : DbContext
    {
        public readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration, DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          
        }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Voter> Voters { get; set; }
    }
}
