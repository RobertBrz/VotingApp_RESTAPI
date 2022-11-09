using System.ComponentModel.DataAnnotations;

namespace VotingApp.Domain.Models.Interfaces
{
    public interface IVoter
    {
        void SetAsVoted(bool voted = true);
        Voter GetInstance();
    }
}
