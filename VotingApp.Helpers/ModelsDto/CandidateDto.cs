
namespace VotingApp.Helpers.ModelsDto
{
    public class CandidateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Pesel { get; set; }


        public CandidateDto(string name, long pesel)
        {
            Name = name;
            Pesel = pesel;
        }
    }
}
