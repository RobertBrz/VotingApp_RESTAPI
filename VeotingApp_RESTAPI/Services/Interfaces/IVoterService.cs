using VotingApp_RESTAPI.Model;

namespace VotingApp_RESTAPI.Services.Interfaces
{
    public interface IVoterService
    {
        int AddVoter();
        IVoter GetVoter();
    }
}
