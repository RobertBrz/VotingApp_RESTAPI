using System.Collections;
using System.Collections.Generic;
using VotingApp.Shared.ModelsDto;

namespace VotingApp.Voters.Domain.Services.Interfaces
{
    public interface ICandidateService
    {
        IEnumerable<CandidateDto> GetCandidates();
        CandidateDto GetCandidate(int id);
        void AddCandidate(string name, long pesel);
    }
}
