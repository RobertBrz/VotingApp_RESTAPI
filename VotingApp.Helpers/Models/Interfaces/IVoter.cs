using System.ComponentModel.DataAnnotations;

namespace VotingApp.Helpers.Models.Interfaces
{
    public interface IVoter
    {
        void SetAsVoted(bool voted = true);
        Voter GetInstance();
    }
}
