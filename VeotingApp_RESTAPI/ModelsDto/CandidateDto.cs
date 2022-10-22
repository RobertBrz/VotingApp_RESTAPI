using VotingApp_RESTAPI.Models.Interfaces;

namespace VotingApp_RESTAPI.ModelsDto
{
    public class CandidateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Pesel { get; set; }
    }
}
