using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Domain.EntityFrameworkRepositories
{
    public interface IVoterRepository<T> : IRepository<T> where T : class
    {
        void Vote(int candidateid, int id);
    }
}
