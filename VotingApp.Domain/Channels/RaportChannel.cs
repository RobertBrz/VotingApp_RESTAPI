using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using VotingApp.Shared.ModelsDto;
using VotingApp.Voters.Domain.Requests;

namespace VotingApp.Voters.Domain.Channels
{
    public class RaportChannel
    {
        Channel<RaportRequest> _channel = Channel.CreateUnbounded<RaportRequest>();

        public ValueTask PubicAsync(RaportRequest raportRequest)
        {
            return _channel.Writer.WriteAsync(raportRequest);
        }

        public IAsyncEnumerable<RaportRequest> SubscribeAsync(CancellationToken cancellationToken)
        {
            return _channel.Reader.ReadAllAsync();
        }
    }
}
