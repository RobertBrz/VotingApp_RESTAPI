using AutoMapper;
using AutoMapper.Execution;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Collections.Generic;
using System.Linq;
using VotingApp.Shared.CustomExceptions;
using VotingApp.Shared.ModelsDto;
using VotingApp.Shared.RepositoryInterfaces;
using VotingApp.Voters.Domain.Models.Voter;
using VotingApp.Voters.Domain.Services.Interfaces;

namespace VotingApp.Voters.Domain.Services
{
    public class VoterService : IVoterService
    {
        IMapper _mapper;
        IVoterRepository<Voter> _voterRepository;

        public VoterService(IMapper mapper,
            IVoterRepository<Voter> voterRepository)
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

        public void AddVoter(string name, long pesel)
        {
            var voterDto = new VoterDto(name, pesel);
            _voterRepository.AddSingle(_mapper.Map<Voter>(voterDto));
        }

        public void Vote(int candidateid, int id)
        {

            _voterRepository.Vote(candidateid, id);
        }
    }
}
