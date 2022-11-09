using System.ComponentModel.DataAnnotations;

namespace VotingApp.Helpers.MappingProfiles.Interfaces
{
    public interface IVoter
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public long Pesel { get; set; }
        [Required]
        public string Name { get; set; }
        public bool HasVoted { get; set; }

        void SetAsVoted(bool voted = true);
        IVoter GetInstance();
    }
}
