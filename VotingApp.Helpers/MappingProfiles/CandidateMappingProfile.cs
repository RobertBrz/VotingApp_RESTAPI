using AutoMapper;
using VotingApp.Helpers.MappingProfiles.Interfaces;
using VotingApp.Helpers.ModelsDto;

namespace VotingApp.Helpers.MappingProfiles
{
    public class CandidateMappingProfile : Profile
    {
        public CandidateMappingProfile()
        {
            CreateMap<ICandidate, CandidateDto>();
            CreateMap<CandidateDto, ICandidate>();
            CreateMap<VoterDto, IVoter>();
            CreateMap<IVoter, VoterDto>();
        }
    }
}
