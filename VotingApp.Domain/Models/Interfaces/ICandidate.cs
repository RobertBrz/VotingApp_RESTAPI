using System.ComponentModel.DataAnnotations;

namespace VotingApp.Domain.Models.Interfaces
{
    public interface ICandidate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public long Pesel { get; set; }

        [Required]
        public string Name { get; set; }

        public int Votes { get; set; }

        void AddVote();
        long GetPesel();
        ICandidate GetInstance();
    }
}
