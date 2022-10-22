using System.Collections;
using System.Collections.Generic;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.Models.Interfaces;
using VotingApp_RESTAPI.ModelsDto;

namespace VotingApp_RESTAPI.Services.Interfaces
{
    public interface IVoterService
    {
        void AddVoter(VoterDto voter);
        VoterDto GetVoter(long pesel);
        IEnumerable<VoterDto> GetVoters();
        void Vote(CandidateDto candidate, long pesel);
    }
}
