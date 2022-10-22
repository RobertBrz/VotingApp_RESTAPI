using System.ComponentModel.DataAnnotations;

namespace VotingApp_RESTAPI.Models.Interfaces
{
    public interface IVoter
    {
        void SetAsVoted(bool voted = true);
        Voter GetInstance();
    }
}
