using VotingApp_RESTAPI.ModelsDto;

namespace VotingApp_RESTAPI.Models.Interfaces
{
    public interface ICandidate
    {
        void AddVote();
        long GetPesel();
        Candidate GetInstance();
    }
}
