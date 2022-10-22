using System.ComponentModel.DataAnnotations;
using System.Security;
using VotingApp_RESTAPI.Models.Interfaces;

namespace VotingApp_RESTAPI.Models
{
    public class Voter : IVoter
    {
        [Key]
        [Required]
        public long Pesel { get; set; }
        [Required]
        public string Name { get; set; }
        public bool HasVoted { get; set; } = false;

        public Voter GetInstance()
        {
            return this;
        }

        public long GetPesel()
        {
          return Pesel; 
        }

        public void SetAsVoted(bool voted = true)
        {
            HasVoted = voted;
        }
    }
}
