namespace VotingApp_RESTAPI.Models.Interfaces
{
    public interface IVoter
    {
        void SetAsVoted(bool voted = true);
        long GetPesel();
        Voter GetInstance();
    }
}
