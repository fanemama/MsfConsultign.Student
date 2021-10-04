
using Microsoft.Extensions.DependencyInjection;
using MsfConsulting.Lausa.Data.Model;
using MsfConsulting.Lausa.Data.Repository;
using MsfConsulting.Lausa.Domain.Service;

namespace MsfConsulting.Lausa.Student.Api
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
            services.AddScoped<IRepository<Data.Model.Enrollment>, Repository<Data.Model.Enrollment>>();
            services.AddScoped<IRepository<Unenrollment>, Repository<Unenrollment>>();
            services.AddScoped<IRepository<Grade>, Repository<Grade>>();
            services.AddScoped<IRepository<Data.Model.Student>, Repository<Data.Model.Student>>();
            services.AddScoped<IRepository<Grade>, Repository<Grade>>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRepository<Data.Model.Student>, Repository<Data.Model.Student>>();
            services.AddScoped<IEnrollmentService, EnrollmentService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IGradeService, GradeService>();
            services.AddScoped<ICourseService, CourseService>();
        }
    }
}
