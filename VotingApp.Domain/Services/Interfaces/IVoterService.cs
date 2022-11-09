
using VotingApp.Helpers.ModelsDto;

namespace VotingApp.Domain
{
    public interface IVoterService
    {
        void AddVoter(VoterDto voter);
        VoterDto GetVoter(int id);
        IEnumerable<VoterDto> GetVoters();
        void Vote(int candidate, int id);
    }
}
