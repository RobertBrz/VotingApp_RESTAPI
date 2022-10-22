//using System.Drawing;
//using VotingApp_RESTAPI.DBContexts;
//using VotingApp_RESTAPI.Models;

//namespace VotingApp_RESTAPI.Entities
//{
//    public class VoterRepository
//    {
//        private ApplicationDbContext _entities = new ApplicationDbContext();

//        public VoterRepository(ApplicationDbContext appEntities)
//        {
//            _entities = appEntities;
//        }

//        public void Add(Voter voter)
//        {
//            _entities.Voters.Add(voter);
//        }

//        public void Delete(Voter voter)
//        {
//            _entities.Voters.Remove(voter);
//        }

//        public void SaveChanges()
//        {
//            _entities.SaveChanges();
//        }
//    }
//}
