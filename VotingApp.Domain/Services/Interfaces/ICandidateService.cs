using System.Collections;
using System.Collections.Generic;
using VotingApp.Helpers.ModelsDto;

namespace VotingApp.Domain
{
    public interface ICandidateService
    {
        IEnumerable<CandidateDto> GetCandidates();
        CandidateDto GetCandidate(int   id);
        void AddCandidate(string name  ,long pesel);
    }
}
