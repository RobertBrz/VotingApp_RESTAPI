using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using VotingApp.Shared.RepositoryInterfaces;
using VotingApp.Voters.Domain.Models;
using VotingApp.Voters.Domain.Services;
using VotingApp.Voters.Domain.Services.Interfaces;
using VotingApp.Voters.Infrastructure.EntityFrameworkRepositories;

namespace VotingApp.Candidates.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddCandidateModule(this IServiceCollection services)
        {
            services.AddTransient<ICandidateRepository<Candidate>, CandidateRepository<Candidate>>();
            services.AddTransient<ICandidateService, CandidateService>();

            return services;
        }

        public static IApplicationBuilder UseCandidateModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}