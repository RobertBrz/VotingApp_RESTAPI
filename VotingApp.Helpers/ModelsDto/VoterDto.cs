namespace VotingApp.Shared.ModelsDto
{
    public class VoterDto
    {
        public int Id { get; set; }
        public long Pesel { get; set; }
        public string Name { get; set; }


        public VoterDto(string name, long pesel)
        {
            Name = name;
            Pesel = pesel;
        }
    }
}
