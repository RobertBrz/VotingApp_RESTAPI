using AutoMapper;
using AutoMapper.Execution;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Collections.Generic;
using System.Linq;
using VotingApp_RESTAPI.CustomExceptions;
using VotingApp_RESTAPI.DBContexts;
using VotingApp_RESTAPI.EntitiyFrameworkRepositories;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.Models.Interfaces;
using VotingApp_RESTAPI.ModelsDto;
using VotingApp_RESTAPI.Services.Interfaces;

namespace VotingApp_RESTAPI.Services
{
    public class VoterService : IVoterService
    {
        IMapper _mapper;
        VoterRepository<Voter> _voterRepository;

        public VoterService(IMapper mapper,
            VoterRepository<Voter> voterRepository)
        {
            _mapper = mapper;
            _voterRepository = voterRepository;
        }

        public IEnumerable<VoterDto> GetVoters()
        {
            var voters = _voterRepository.GetAll();
            var result = _mapper.Map<IEnumerable<VoterDto>>(voters);
            return result;
        }

        public VoterDto GetVoter(int id)
        {
            var voter = _voterRepository.GetSingle(id);
            if (voter.Equals(null)) throw new VoterNotFoundException();
            return _mapper.Map<VoterDto>(voter);
        }

        public void AddVoter(VoterDto voterdto)
        {
            _voterRepository.AddSingle(_mapper.Map<Voter>(voterdto));
        }

        public void Vote(int candidateid, int id)
        {

            _voterRepository.Vote(candidateid, id);
        }
    }
}
