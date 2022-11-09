
using VotingApp.Helpers.ModelsDto;

namespace VotingApp.Domain
{
    public interface IVoterService
    {
        void AddVoter(string name, long pesel);
        VoterDto GetVoter(int id);
        IEnumerable<VoterDto> GetVoters();
        void Vote(int candidate, int id);
    }
}
