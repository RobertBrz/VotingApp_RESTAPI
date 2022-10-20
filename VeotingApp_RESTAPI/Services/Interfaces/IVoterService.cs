using System.Collections;
using System.Collections.Generic;
using VotingApp_RESTAPI.Models;

namespace VotingApp_RESTAPI.Services.Interfaces
{
    public interface IVoterService
    {
        int AddVoter(IVoter voter);
        IVoter GetVoter(int id);
        IEnumerable<IVoter> GetVoters();
    }
}
