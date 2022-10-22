namespace VotingApp_RESTAPI.Models.Interfaces
{
    public interface ICandidate
    {
        string Pesel { get; set; }

        public void AddVote();
    }
}
