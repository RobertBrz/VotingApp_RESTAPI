using AutoMapper;
using VotingApp.Helpers.Models;
using VotingApp.Helpers.ModelsDto;

namespace VotingApp.Helpers.MappingProfiles
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
