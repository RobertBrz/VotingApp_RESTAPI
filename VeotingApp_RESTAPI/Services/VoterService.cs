using System.Collections.Generic;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.Services.Interfaces;

namespace VotingApp_RESTAPI.Services
{
    public class VoterService : IVoterService
    {
        public int AddVoter(IVoter voter)
        {
            return 0; 
        }

        public IVoter GetVoter(int id)
        {
            return null;
        }

        public IEnumerable<IVoter> GetVoters()
        {
            return  new List<IVoter>(); 
        }

        public void Vote(ICandidate candidate, int voterID)
        {
           
        }
    }
}
