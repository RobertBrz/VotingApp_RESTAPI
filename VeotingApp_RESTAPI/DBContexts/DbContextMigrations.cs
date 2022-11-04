using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace VotingApp_RESTAPI.DBContexts
{
    public class DbContextMigrations
    {
        ApplicationDbContext _applicationDbContext;

        public DbContextMigrations(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        public void RunMigraitonPolicy()
        {
            //if (_applicationDbContext.Database.CanConnect())
            //{
                var pendingMigrations = _applicationDbContext.Database.GetPendingMigrations();
                if (pendingMigrations != null && pendingMigrations.Any()) _applicationDbContext.Database.Migrate();
            //}

        }
    }
}
