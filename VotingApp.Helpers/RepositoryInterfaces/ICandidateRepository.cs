using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Shared.RepositoryInterfaces
{
    public interface ICandidateRepository<T> : IRepository<T> where T : class
    {
    }
}
