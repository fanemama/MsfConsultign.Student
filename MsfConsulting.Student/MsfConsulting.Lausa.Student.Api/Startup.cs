using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MsfConsulting.Lausa.Application.Service.Command;
using MsfConsulting.Lausa.Data.Model;
using MsfConsulting.Lausa.Data.Repository;
using MsfConsulting.Lausa.Domain.Service;
using MsfConsulting.Lausa.Domain.Service.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Student.Api
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MsfConsulting.Lausa.Student.Api", Version = "v1" });
            });

            services.AddDbContext<LausaDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IRepository<Course>, Repository<Course>>();
            services.AddScoped<IRepository<Enrollment>, Repository<Enrollment>>();
            services.AddScoped<IRepository<Unenrollment>, Repository<Unenrollment>>();
            services.AddScoped<IRepository<Grade>, Repository<Grade>>();
            services.AddScoped<IRepository<Data.Model.Student>, Repository<Data.Model.Student>>();
            services.AddScoped<IRepository<Grade>, Repository<Grade>>();
            services.AddScoped<IRepository<Data.Model.Student>, Repository<Data.Model.Student>>();
            services.AddScoped<IEnrollmentService, EnrollmentService>();
            services.AddScoped<IStudentService, StudentService> ();

            services.AddAutoMapper(typeof(DomainProfile).Assembly, typeof(ApplicationProfile).Assembly);
            services.AddMediatR(Assembly.GetAssembly(typeof(UnregisterCommandHandler)));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MsfConsulting.Lausa.Student.Api v1"));
            }

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
