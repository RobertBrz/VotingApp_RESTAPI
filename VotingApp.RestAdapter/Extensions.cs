using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Shared.RepositoryInterfaces;
using VotingApp.Voters.Domain.Channels;
using VotingApp.Voters.Domain.Processors;
using VotingApp.Voters.Domain.Requests;
using VotingApp.Voters.Domain.Services.Interfaces;
using VotingApp.Voters.Domain.Services;
using VotingApp.Voters.Domain.Models.Voter;
using VotingApp.Voters.Infrastructure.EntityFrameworkRepositories;

namespace VotingApp.Voters.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddVotersModule(this IServiceCollection services)
        {
            services.AddTransient<IVoterRepository<Voter>, VoterRepository<Voter>>();
            services.AddTransient<IVoterService, VoterService>();

            return services;
        }
    }
}
