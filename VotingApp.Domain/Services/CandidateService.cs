﻿using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using VotingApp.Domain.Models;
using VotingApp.Helpers.CustomExceptions;
using VotingApp.Helpers.ModelsDto;
using VotingApp.Helpers.Repositories;

namespace VotingApp.Domain
{
    public class CandidateService : ICandidateService
    {
        IMapper _mapper;
        ICandidateRepository<Candidate> _candidateRepository;
        //CandidateRepository<Candidate> _candidateRepository;

        public CandidateService(
            IMapper mapper,
           ICandidateRepository<Candidate> candidateRepository
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
