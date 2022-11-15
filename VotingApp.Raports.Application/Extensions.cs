using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Shared.RepositoryInterfaces;
using VotingApp.Voters.Domain.Services;
using VotingApp.Voters.Infrastructure.EntityFrameworkRepositories;
using VotingApp.Voters.Domain.Processors;
using VotingApp.Voters.Domain.Services.Interfaces;
using VotingApp.Voters.Domain.Channels;
using VotingApp.Voters.Domain.Requests;

namespace VotingApp.Raports.Application
{
    public static class Extensions
    {

        public static IServiceCollection AddRaportModule(this IServiceCollection services)
        {
            services.AddTransient<IRaportRepository<RaportRequest>, RaportRepository<RaportRequest>>();
            services.AddSingleton<RaportChannel>();
            services.AddSingleton<IRaportService, RaportService>();
            services.AddSingleton<RaportProcessor>();
            services.AddHostedService<RaportBackgroundProcessor>();

            return services;
        }

    }
}
