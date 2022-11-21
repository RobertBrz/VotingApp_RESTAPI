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
using VotingApp.Candidates.Application;
using VotingApp.Raports.Application;
using VotingApp.Shared.IRaportRequest;
using VotingApp.Shared.RepositoryInterfaces;
using VotingApp.Voters.Application;
using VotingApp.Voters.Domain.MappingProfiles;
using VotingApp.Voters.Domain.Models.Voter;
using VotingApp.Voters.Domain.Services;
using VotingApp.Voters.Domain.Services.Interfaces;
using VotingApp.Voters.Infrastructure.DBContext;
using VotingApp.Voters.Infrastructure.EntityFrameworkRepositories;

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
            services.AddControllers();
            services.AddAutoMapper(typeof(CandidateMappingProfile).GetTypeInfo().Assembly);
            services.AddRaportModule();
            services.AddCandidateModule();
            services.AddVotersModule();
            services.AddScoped<DbContextMigrations>();
            services.AddScoped<ErrorHandlingMiddleware>();
            services.AddCors(options => options.AddPolicy("TestPolicy", policyBuilder =>
            {
                policyBuilder.AllowAnyHeader();
                policyBuilder.AllowAnyMethod();
                policyBuilder.AllowAnyOrigin();
            }));

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
            app.UseCors("TestPolicy");
            dbContextMigrations.RunMigraitonPolicy();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "VeotingApp_RESTAPI v1"));
            }
            app.UseCandidateModule();
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
