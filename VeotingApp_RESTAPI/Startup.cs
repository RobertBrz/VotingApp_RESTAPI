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
using System.Threading.Tasks;
using VotingApp.Domain;
using VotingApp.Domain.Models;
using VotingApp.Helpers.MappingProfiles.Interfaces;
using VotingApp.Helpers.Repositories;

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
            services.AddAutoMapper(this.GetType().Assembly);
            services.AddScoped<DbContextMigrations>();
            services.AddTransient< VoterRepository<Voter>>();
            services.AddScoped<CandidateRepository<Candidate>>();
            services.AddTransient<ICandidateService, CandidateService>();
            services.AddTransient<IVoterService, VoterService>();
            services.AddControllers();
            services.AddScoped<ErrorHandlingMiddleware>();

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
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env/*, DbContextMigrations dbContextMigrations*/)
        {
            //dbContextMigrations.RunMigraitonPolicy();
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
