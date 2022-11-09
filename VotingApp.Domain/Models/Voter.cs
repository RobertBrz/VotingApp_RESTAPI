using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Security;
using VotingApp.Helpers.MappingProfiles.Interfaces;

namespace VotingApp.Domain.Models
{
    [Index("Pesel", IsUnique = true, Name = "PeselIndex")]
    public class Voter : IVoter
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public long Pesel { get; set; }
        [Required]
        public string Name { get; set; }
        public bool HasVoted { get; set; } = false;

        public Voter GetInstance()
        {
            return this;
        }


        public void SetAsVoted(bool voted = true)
        {
            HasVoted = voted;
        }
    }
}
