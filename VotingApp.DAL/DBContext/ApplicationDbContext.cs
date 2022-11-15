using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VotingApp.Voters.Domain.Models;
using VotingApp.Voters.Domain.Models.Voter;

namespace VotingApp.Voters.Infrastructure.DBContext
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
