//using VotingApp_RESTAPI.DBContexts;
//using VotingApp_RESTAPI.Models;

//namespace VotingApp_RESTAPI.Entities
//{
//    public class CandidateRepository
//    {

//        private ApplicationDbContext _entities = new ApplicationDbContext();

//        public CandidateRepository(ApplicationDbContext entites)
//        {
//            _entities = entites;
//        }

//        public void Add(Candidate candidate)
//        {
//            _entities.Candidates.Add(candidate);
//        }

//        public void Delete(Candidate candidate)
//        {
//            _entities.Candidates.Remove(candidate);
//        }

//        public void SaveChanges()
//        {
//            _entities.SaveChanges();
//        }
//    }
//}
