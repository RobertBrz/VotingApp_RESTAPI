using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using VotingApp.Domain.Channels;
using VotingApp.Domain.Requests;
using VotingApp.Domain.Services.Interfaces;
using VotingApp.Shared.ModelsDto;

namespace VotingApp.Domain.Services
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
