using Microsoft.EntityFrameworkCore;
using VotingApp_RESTAPI.Models;

namespace VotingApp_RESTAPI.DBContexts
{
    public class AppEntities :DbContext
    {

        public AppEntities():base()
        {

        }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Voter> Voters{ get; set; }
    }
}
