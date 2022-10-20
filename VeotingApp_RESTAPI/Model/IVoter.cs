namespace VotingApp_RESTAPI.Model
{
    public interface IVoter
    {
        void SetAsVoted(bool voted = true);
    }
}
