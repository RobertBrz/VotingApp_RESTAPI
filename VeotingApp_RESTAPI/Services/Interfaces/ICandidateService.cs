using System.Collections;
using System.Collections.Generic;
using VotingApp_RESTAPI.Models;

namespace VotingApp_RESTAPI.Services.Interfaces
{
    public interface ICandidateService
    {
        IEnumerable<ICandidate> GetCandidates();
        ICandidate GetCandidate(int id);
        void AddCandidate(ICandidate candidate);
        void DeleteCandidate   (ICandidate candidate);  
    }
}
