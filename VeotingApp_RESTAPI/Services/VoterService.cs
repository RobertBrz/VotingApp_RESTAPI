using AutoMapper;
using AutoMapper.Execution;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Collections.Generic;
using System.Linq;
using VotingApp_RESTAPI.CustomExceptions;
using VotingApp_RESTAPI.DBContexts;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.Models.Interfaces;
using VotingApp_RESTAPI.ModelsDto;
using VotingApp_RESTAPI.Services.Interfaces;

namespace VotingApp_RESTAPI.Services
{
    public class VoterService : IVoterService
    {
        IMapper _mapper;
        ApplicationDbContext _applicationDbContext;

        public VoterService(IMapper mapper,
            ApplicationDbContext appEntities)
        {
            _mapper = mapper;
            _applicationDbContext = appEntities;
        }
        public void AddVoter(VoterDto voter)
        {
            _applicationDbContext.Voters.Add(_mapper.Map<Voter>(voter));
            _applicationDbContext.SaveChanges();
        }

        public VoterDto GetVoter(long pesel)
        {
            var voter = _applicationDbContext.Voters.Find(pesel);
            if (voter.Equals(null)) throw new VoterNotFoundException();
            return _mapper.Map<VoterDto>(voter);
        }

        public IEnumerable<VoterDto> GetVoters()
        {
            var voters = _applicationDbContext.Voters;
            var result = _mapper.Map<IEnumerable<VoterDto>>(voters);
            return result;
        }

        public void Vote(CandidateDto candidate, long pesel)
        {
            if (_applicationDbContext.Candidates.Find(candidate.Pesel) == null) throw new CandidateNotFoundException();
            if (_applicationDbContext.Voters.Find(pesel) == null) throw new VoterNotFoundException();

            _applicationDbContext.Candidates.Find(candidate.Pesel).AddVote();
            _applicationDbContext.Voters.Find(pesel).SetAsVoted();

            _applicationDbContext.SaveChanges();
        }
    }
}
