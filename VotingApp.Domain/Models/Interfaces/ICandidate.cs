namespace VotingApp.Domain.Models.Interfaces
{
    public interface ICandidate
    {
        void AddVote();
        long GetPesel();
        Candidate GetInstance();
    }
}
