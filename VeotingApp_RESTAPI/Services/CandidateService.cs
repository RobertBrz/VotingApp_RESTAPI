using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using VotingApp_RESTAPI.CustomExceptions;
using VotingApp_RESTAPI.DBContexts;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.Models.Interfaces;
using VotingApp_RESTAPI.ModelsDto;
using VotingApp_RESTAPI.ModelsDto.Interfaces;
using VotingApp_RESTAPI.Services.Interfaces;

namespace VotingApp_RESTAPI.Services
{
    public class CandidateService : ICandidateService
    {
        ApplicationDbContext _appEntities;
        IMapper _mapper;

        public CandidateService(ApplicationDbContext appEntities,
            IMapper mapper)
        {
            _appEntities = appEntities;
            _mapper = mapper;
        }

        public void AddCandidate(Candidate candidate)
        {
            _appEntities.Candidates.Add(candidate);
            _appEntities.SaveChanges();
        }

        public void DeleteCandidate(Candidate candidate)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ICandidateDto> GetCandidates()
        {
            var candidates = _appEntities.Candidates;
            var candidatesDto = _mapper.Map<List<CandidateDto>>(candidates);
            return candidatesDto;
        }

        ICandidateDto ICandidateService.GetCandidate(string pesel)
        {
            var candidate = _appEntities.Candidates.FirstOrDefault(c => c.Pesel == pesel);
            if (candidate.Equals(null)) throw new CandidateNotFoundException();
            var candidateDto = _mapper.Map<CandidateDto>(candidate);
            return candidateDto;
        }
    }
}
