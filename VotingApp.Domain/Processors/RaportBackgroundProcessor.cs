using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Domain.Channels;
using VotingApp.Domain.Services;

namespace VotingApp.Domain.Processors
{
    public class RaportBackgroundProcessor : BackgroundService
    {
        private readonly RaportChannel _raportChannel;
        RaportProcessor _raportProcessor;

        public RaportBackgroundProcessor(RaportChannel raportChannel, RaportProcessor raportProcessor)
        {
            _raportChannel = raportChannel;
            _raportProcessor = raportProcessor;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await foreach (var request in _raportChannel.SubscribeAsync(stoppingToken))
            {
                await _raportProcessor.ProcessRaport(request);
            }
        }
    }
}
