using System.Collections;
using System.Collections.Generic;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.Models.Interfaces;
using VotingApp_RESTAPI.ModelsDto;

namespace VotingApp_RESTAPI.Services.Interfaces
{
    public interface ICandidateService
    {
        IEnumerable<CandidateDto> GetCandidates();
        CandidateDto GetCandidate(long  pesel);
        void AddCandidate(CandidateDto candidate);
    }
}
