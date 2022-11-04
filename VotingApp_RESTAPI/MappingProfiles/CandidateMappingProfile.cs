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
            CreateMap<CandidateDto, Candidate>();
            CreateMap<VoterDto, Voter>();
            CreateMap<Voter, VoterDto>();
        }
    }
}
