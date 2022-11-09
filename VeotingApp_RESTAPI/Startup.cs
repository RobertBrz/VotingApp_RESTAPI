using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using VotingApp.DAL.DBContext;
using VotingApp.DAL.EntityFrameworkRepositories;
using VotingApp.Domain.MappingProfiles;
using VotingApp.Domain.Models;
using VotingApp.Domain.Models.Voter;
using VotingApp.Domain.Services;
using VotingApp.Domain.Services.Interfaces;
using VotingApp.Shared.RepositoryInterfaces;

namespace VotingApp_RESTAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CandidateMappingProfile).GetTypeInfo().Assembly);
            services.AddScoped<DbContextMigrations>();
            services.AddTransient<IVoterRepository<Voter>, VoterRepository<Voter>>();
            services.AddTransient<ICandidateRepository<Candidate>, CandidateRepository<Candidate>>();
            services.AddTransient<ICandidateService, CandidateService>();
            services.AddTransient<IVoterService, VoterService>();
            services.AddScoped<ErrorHandlingMiddleware>();
            services.AddControllers();

            services.AddDbContext<ApplicationDbContext>(optionsBuilder =>
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("LocalConnection"));
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "VeotingApp_RESTAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DbContextMigrations dbContextMigrations)
        {
            dbContextMigrations.RunMigraitonPolicy();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "VeotingApp_RESTAPI v1"));
            }
            app.UseMiddleware<ErrorHandlingMiddleware>();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
