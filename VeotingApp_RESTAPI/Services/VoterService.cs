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

        public VoterDto GetVoter(int id)
        {
            var voter = _applicationDbContext.Voters.FirstOrDefault(v => v.Id.Equals(id));
            if (voter.Equals(null)) throw new VoterNotFoundException();
            return _mapper.Map<VoterDto>(voter);
        }

        public IEnumerable<VoterDto> GetVoters()
        {
            var voters = _applicationDbContext.Voters;
            var result = _mapper.Map<IEnumerable<VoterDto>>(voters);
            return result;
        }

        public void Vote(int candidateid, int id)
        {
            if (_applicationDbContext.Candidates.FirstOrDefault(c => c.Id.Equals(candidateid)).Equals(null)) throw new CandidateNotFoundException();
            if (_applicationDbContext.Voters.FirstOrDefault(v => v.Id.Equals(id)).Equals(null)) throw new VoterNotFoundException();

            _applicationDbContext.Candidates.FirstOrDefault(c => c.Id.Equals(candidateid)).AddVote();
            _applicationDbContext.Voters.FirstOrDefault(v => v.Id.Equals(id)).SetAsVoted();

            _applicationDbContext.SaveChanges();
        }
    }
}
