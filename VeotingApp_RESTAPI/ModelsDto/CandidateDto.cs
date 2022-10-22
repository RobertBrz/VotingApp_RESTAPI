using VotingApp_RESTAPI.Models.Interfaces;
using VotingApp_RESTAPI.ModelsDto.Interfaces;

namespace VotingApp_RESTAPI.ModelsDto
{
    public class CandidateDto : ICandidateDto
    {
        public string Name { get; set; }
        public string Pesel { get; set; }

    }
}
