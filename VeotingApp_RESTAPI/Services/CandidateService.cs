using AutoMapper;
using Microsoft.AspNetCore.Routing.Matching;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using VotingApp_RESTAPI.CustomExceptions;
using VotingApp_RESTAPI.DBContexts;
using VotingApp_RESTAPI.EntitiyFrameworkRepositories;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.Models.Interfaces;
using VotingApp_RESTAPI.ModelsDto;
using VotingApp_RESTAPI.Services.Interfaces;

namespace VotingApp_RESTAPI.Services
{
    public class CandidateService : ICandidateService
    {
        IMapper _mapper;
        CandidateRepository<Candidate> _candidateRepository;

        public CandidateService(
            IMapper mapper,
            CandidateRepository<Candidate> candidateRepository
            )
        {
            _candidateRepository = candidateRepository;
            _mapper = mapper;
        }

        public void AddCandidate(string name, long pesel)
        {
            CandidateDto candidateDto = new CandidateDto(name, pesel);
            var candidate = _mapper.Map<Candidate>(candidateDto);
            _candidateRepository.AddSingle(candidate);
        }

        public IEnumerable<CandidateDto> GetCandidates()
        {
            var candidates = _candidateRepository.GetAll();
            var candidatesDto = _mapper.Map<List<CandidateDto>>(candidates);
            return candidatesDto;
        }

        CandidateDto ICandidateService.GetCandidate(int id)
        {
            var candidate = _candidateRepository.GetSingle(id);
            if (candidate.Equals(null)) throw new CandidateNotFoundException();
            var candidateDto = _mapper.Map<CandidateDto>(candidate);
            return candidateDto;
        }
    }
}
