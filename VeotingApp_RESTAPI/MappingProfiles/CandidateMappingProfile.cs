using AutoMapper;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.ModelsDto;

namespace VotingApp_RESTAPI.MappingProfiles
{
    public class CandidateMappingProfile : Profile
    {
        public CandidateMappingProfile()
        {
            CreateMap<Candidate, CandidateDto>();
        }
    }
}
