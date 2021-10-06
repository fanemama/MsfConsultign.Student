using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MsfConsulting.Lausa.Application.Service.Command;
using MsfConsulting.Lausa.Domain.Repository;
using MsfConsulting.Lausa.Domain.Service.Mapping;
using MsfConsulting.Lausa.Api.Mapping;
using System.Reflection;

namespace MsfConsulting.Lausa.Api
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
            services.AddDbContext<LausaDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(typeof(ApiProfile).Assembly, typeof(ApplicationProfile).Assembly);
            
            services.AddMediatR(Assembly.GetAssembly(typeof(UnregisterCommandHandler)));
            
            services.AddMiddleOfficeServices();

            services.AddControllers();
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MsfConsulting.Lausa.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MsfConsulting.Lausa.Api v1"));
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
