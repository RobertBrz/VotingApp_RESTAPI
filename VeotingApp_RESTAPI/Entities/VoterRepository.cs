using System.Drawing;
using VotingApp_RESTAPI.DBContexts;
using VotingApp_RESTAPI.Models;

namespace VotingApp_RESTAPI.Entities
{
    public class VoterRepository
    {

        private AppEntities _entities = new AppEntities();

        public VoterRepository(AppEntities appEntities)
        {
            _entities = appEntities;
        }

        public void Add(Voter voter)
        {
            _entities.Voters.Add(voter);
        }

        public void Delete(Voter voter)
        {
            _entities.Voters.Remove(voter);
        }

        public void SaveChanges()
        {
            _entities.SaveChanges();
        }
    }
}
