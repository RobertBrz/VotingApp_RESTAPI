using System.Collections;
using System.Collections.Generic;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.Models.Interfaces;

namespace VotingApp_RESTAPI.Services.Interfaces
{
    public interface IVoterService
    {
        void AddVoter(IVoter voter);
        IVoter GetVoter(long pesel);
        IEnumerable<IVoter> GetVoters();
        void Vote(ICandidate candidate, string name);
    }
}
