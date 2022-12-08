using VotingApp.Shared.ModelsDto;

namespace VotingApp.Voters.Domain.Services.Interfaces
{
    public interface IVoterService
    {
        void AddVoter(string name, long pesel);
        VoterDto GetVoter(int id);
        IEnumerable<VoterDto> GetVoters();
        VoteDto Vote(VoteDto voteDto);
        VoterDto UpdateVoter( VoterDto voterDto);
    }
}
