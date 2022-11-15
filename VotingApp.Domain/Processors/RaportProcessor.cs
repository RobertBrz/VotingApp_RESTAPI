using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Shared.IRaportRequest;
using VotingApp.Shared.RepositoryInterfaces;
using VotingApp.Voters.Domain.Requests;

namespace VotingApp.Voters.Domain.Processors
{
    public class RaportProcessor
    {
        //IRaportRepository<RaportRequest> _raportRepository;
        IServiceScopeFactory _serviceScopeFactory;
        public RaportProcessor(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public async ValueTask ProcessRaport(RaportRequest raportRequest)
        {
            //business logic 
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var raportrepo = scope.ServiceProvider.GetRequiredService<IRaportRepository<RaportRequest>>();
                var result = await raportrepo.Get(raportRequest);
            }
            //var result = await _raportRepository.Get(raportRequest);
        }
    }
}
