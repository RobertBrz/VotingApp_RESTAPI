using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using VotingApp.Shared.RepositoryInterfaces;
using VotingApp.Voters.Domain.Models;
using VotingApp.Voters.Infrastructure.DBContext;

namespace VotingApp.Voters.Infrastructure.EntityFrameworkRepositories
{
    public class CandidateRepository<T> : ICandidateRepository<T> where T : Candidate
    {
        ApplicationDbContext _applicationDbContext;
        IMapper _mapper;

        public CandidateRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public void AddSingle(T param)
        {
            _applicationDbContext.Candidates.Add(param);
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            var candidates = (IEnumerable<T>)_applicationDbContext.Candidates;
            return candidates;
        }

        public T GetSingle(int id)
        {
            return (T)_applicationDbContext.Candidates.FirstOrDefault(c => c.Id == id);
        }

        public void SaveChanges()
        {
            _applicationDbContext.SaveChanges();
        }
    }
}
