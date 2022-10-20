namespace VotingApp_RESTAPI.Model
{
    public class Candidate :ICandidate
    {
        public string Name{ get; set; } 
        public int  Votes { get; set; }


        public void AddVote()
        {
            Votes++;
        }
    }
}
