using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using VotingApp.Shared.ModelsDto;
using VotingApp.Voters.Domain.Channels;
using VotingApp.Voters.Domain.Requests;
using VotingApp.Voters.Domain.Services.Interfaces;

namespace VotingApp.Voters.Domain.Services
{
    public class RaportService : IRaportService
    {
        RaportChannel _raportChannel;

        public RaportService(RaportChannel raportChannel)
        {
            _raportChannel = raportChannel;
        }

        public ValueTask GenerateReport(RaportRequest raportRequest)
        {
            return _raportChannel.PubicAsync(raportRequest);
        }
    }
}
