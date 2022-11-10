using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Domain.Channels;
using VotingApp.Domain.Models;
using VotingApp.Domain.Requests;
using VotingApp.Shared.IRaportRequest;
using VotingApp.Shared.RepositoryInterfaces;

namespace VotingApp.Domain.Processors
{
    public class RaportProcessor
    {
        IRaportRepository<RaportRequest> _raportRepository;
        public RaportProcessor( IRaportRepository<RaportRequest> raportRepository)
        {
            _raportRepository = raportRepository;
        }
        public async ValueTask ProcessRaport(RaportRequest raportRequest)
        {
            //_raportRepository.Get(raportRequest);
            //raportRequest.
            //new RaportResult()
        }
    }
}
