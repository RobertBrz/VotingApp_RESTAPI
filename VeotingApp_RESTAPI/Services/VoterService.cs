using AutoMapper;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Collections.Generic;
using System.Linq;
using VotingApp_RESTAPI.CustomExceptions;
using VotingApp_RESTAPI.DBContexts;
using VotingApp_RESTAPI.Models;
using VotingApp_RESTAPI.Models.Interfaces;
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
        public void AddVoter(IVoter voter)
        {
            _applicationDbContext.Voters.Add(voter.GetInstance());
            _applicationDbContext.SaveChanges();
        }

        public IVoter GetVoter(long pesel)
        {
            var voter = _applicationDbContext.Voters.FirstOrDefault(v => string.Equals(v.GetPesel(), pesel));
            if (voter.Equals(null)) throw new NoVoterFoundException();
            return voter;
        }

        public IEnumerable<IVoter> GetVoters()
        {
            return _applicationDbContext.Voters;
        }

        public void Vote(ICandidate candidate, string name)
        {

        }
    }
}
