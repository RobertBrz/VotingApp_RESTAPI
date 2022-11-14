using AutoMapper;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.DAL.DBContext;
using VotingApp.Domain.Models;
using VotingApp.Domain.Requests;
using VotingApp.Shared.ModelsDto;
using VotingApp.Shared.RepositoryInterfaces;

namespace VotingApp.DAL.EntityFrameworkRepositories
{
    public class RaportRepository<T> : IRaportRepository<T> where T : RaportRequest
    {
        ApplicationDbContext _applicationDbContext;
        IMapper _mapper;
        public RaportRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        async Task<RaportResult> IRaportRepository<T>.Get(T raportRequest)
        {
            var candidates = _applicationDbContext.Candidates.ToList<Candidate>();
            var candidatesDto = _mapper.Map<List<CandidateDto>>(candidates);
            return new RaportResult(candidatesDto);
        }
    }
}
