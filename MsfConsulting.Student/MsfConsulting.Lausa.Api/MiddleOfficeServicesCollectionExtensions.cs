
using Microsoft.Extensions.DependencyInjection;
using MsfConsulting.Lausa.Domain.Model;
using MsfConsulting.Lausa.Domain.Repository;
using MsfConsulting.Lausa.Domain.Service;

namespace MsfConsulting.Lausa.Api
{


    /// <summary>
    /// Classe d'extension pour gérer l'injection de dépendances des services Middle
    /// </summary>
    public static class MiddleOfficeServicesCollectionExtensions {
        /// <summary>
        /// Configure l'injection de dépendances des services <see cref="ServiceContract"/>
        /// </summary>
        /// <param name="services">Instance du conteneur <see cref="IServiceCollection"/> auquel sont rajoutés les configurations de services</param>
        public static void AddMiddleOfficeServices(this IServiceCollection services) {
          
            services.AddScoped<IRepository<Course>, Repository<Course>>();
            services.AddScoped<IRepository<Domain.Model.Enrollment>, Repository<Domain.Model.Enrollment>>();
            services.AddScoped<IRepository<Unenrollment>, Repository<Unenrollment>>();
            services.AddScoped<IRepository<Grade>, Repository<Grade>>();
            services.AddScoped<IRepository<Domain.Model.Student>, Repository<Domain.Model.Student>>();
            services.AddScoped<IRepository<Grade>, Repository<Grade>>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRepository<Domain.Model.Student>, Repository<Domain.Model.Student>>();
            services.AddScoped<IReferentialRepository<Grade>, ReferentialRepository<Grade>>();
            services.AddScoped< IReferentialRepository<Course>, ReferentialRepository<Course>>();
        }
    }
}
