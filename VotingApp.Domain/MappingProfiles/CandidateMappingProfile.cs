using AutoMapper;
using VotingApp.Domain.Models;
using VotingApp.Domain.Models.Voter;
using VotingApp.Shared.ModelsDto;

namespace VotingApp.Domain.MappingProfiles
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
