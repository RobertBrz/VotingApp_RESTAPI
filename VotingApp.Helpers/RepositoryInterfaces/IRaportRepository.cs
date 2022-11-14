using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Shared.IRaportRequest;
using VotingApp.Shared.ModelsDto;

namespace VotingApp.Shared.RepositoryInterfaces
{
    public interface IRaportRepository<T> where T : class
    {
        Task<RaportResult> Get(T raportRequest);
    }
}
