using AutoMapper;
using AutoMapper.Execution;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Collections.Generic;
using System.Linq;
using VotingApp.Domain.Models;
using VotingApp.Helpers.CustomExceptions;
using VotingApp.Helpers.ModelsDto;

namespace VotingApp.Domain
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
