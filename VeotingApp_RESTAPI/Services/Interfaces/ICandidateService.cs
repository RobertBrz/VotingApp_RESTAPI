using System.Collections;
using System.Collections.Generic;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.Models.Interfaces;
using VotingApp_RESTAPI.ModelsDto.Interfaces;

namespace VotingApp_RESTAPI.Services.Interfaces
{
    public interface ICandidateService
    {
        IEnumerable<ICandidateDto> GetCandidates();
        ICandidateDto GetCandidate(string  pesel);
        void AddCandidate(Candidate candidate);
        void DeleteCandidate(Candidate candidate);
    }
}
