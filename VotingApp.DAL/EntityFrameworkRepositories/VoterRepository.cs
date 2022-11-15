using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using VotingApp.Shared.CustomExceptions;
using VotingApp.Shared.RepositoryInterfaces;
using VotingApp.Voters.Domain.Models.Voter;
using VotingApp.Voters.Infrastructure.DBContext;

namespace VotingApp.Voters.Infrastructure.EntityFrameworkRepositories
{
    public class VoterRepository<T> : IVoterRepository<T> where T : Voter
    {
        private readonly ApplicationDbContext _dbContext;
        IMapper _mapper;
        //private IDbSet<T> _dbSet => _dbContext.Set<T>();
        //public IQueryable<T> Entities => _dbSet;

        public VoterRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IEnumerable<T> GetAll()
        {
            return (IEnumerable<T>)_dbContext.Voters;
        }


        public T GetSingle(int id)
        {
            return (T)_dbContext.Voters.SingleOrDefault(x => x.Id == id);
        }

        public void AddSingle(T param)
        {
            _dbContext.Voters.Add(_mapper.Map<Voter>(param));
            SaveChanges();
        }

        public void Vote(int candidateid, int id)
        {
            if (_dbContext.Candidates.FirstOrDefault(c => c.Id == candidateid).Equals(null)) throw new CandidateNotFoundException();
            if (_dbContext.Voters.FirstOrDefault(v => v.Id == id).Equals(null)) throw new VoterNotFoundException();
            _dbContext.Candidates.FirstOrDefault(c => c.Id == candidateid).AddVote();
            _dbContext.Voters.FirstOrDefault(v => v.Id == id).SetAsVoted();

            SaveChanges();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }


    }
}
