using VotingApp.Shared.ModelsDto;

namespace VotingApp.Domain.Services.Interfaces
{
    public interface IVoterService
    {
        void AddVoter(string name, long pesel);
        VoterDto GetVoter(int id);
        IEnumerable<VoterDto> GetVoters();
        void Vote(int candidate, int id);
    }
}
