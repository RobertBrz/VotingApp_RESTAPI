namespace VotingApp_RESTAPI.Models
{
    public interface IVoter
    {
        void SetAsVoted(bool voted = true);
    }
}
