using AutoMapper;
using VotingApp.Shared.ModelsDto;
using VotingApp.Voters.Domain.Models;
using VotingApp.Voters.Domain.Models.Voter;

namespace VotingApp.Voters.Domain.MappingProfiles
{
    public class CandidateMappingProfile : Profile
    {
        public CandidateMappingProfile()
        {
            CreateMap<Candidate, CandidateDto>();
            CreateMap<CandidateDto, Candidate>();
            CreateMap<VoterDto, Voter>();
            CreateMap<Voter, VoterDto>();
            //CreateMap<List<CandidateDto>, List<Candidate>>();
            //CreateMap<List<Candidate>, List<CandidateDto>>();
        }
    }
}
