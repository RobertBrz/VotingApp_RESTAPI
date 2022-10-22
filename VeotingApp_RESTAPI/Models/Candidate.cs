using System.ComponentModel.DataAnnotations;
using VotingApp_RESTAPI.Models.Interfaces;

namespace VotingApp_RESTAPI.Models
{
    public class Candidate : ICandidate
    {
        [Required]
        public string Name { get; set; }
        [Key]
        [Required]
        public string Pesel { get; set; }
        public int Votes { get; set; } = 0;


        public void AddVote()
        {
            Votes++;
        }
    }
}
