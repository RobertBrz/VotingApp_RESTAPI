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
    public class ReportRepository<T> : IRaportRepository<T> where T : RaportRequest
    {
        ApplicationDbContext _applicationDbContext;
        public ReportRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public RaportResult Get(T raportRequest)
        {
            var candidates = _applicationDbContext.Candidates.ToList<Candidate>();

            return new RaportResult(candidates);
        }
    }
}
