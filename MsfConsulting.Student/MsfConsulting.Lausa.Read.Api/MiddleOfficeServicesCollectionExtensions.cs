
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MsfConsulting.Lausa.Shared;

namespace MsfConsulting.Lausa.Read.Api
{


    /// <summary>
    /// Classe d'extension pour gérer l'injection de dépendances des services Middle
    /// </summary>
    public static class MiddleOfficeServicesCollectionExtensions {
        /// <summary>
        /// Configure l'injection de dépendances des services <see cref="ServiceContract"/>
        /// </summary>
        /// <param name="services">Instance du conteneur <see cref="IServiceCollection"/> auquel sont rajoutés les configurations de services</param>
        public static void AddMiddleOfficeServices(this IServiceCollection services, IConfiguration configuration) {

            var commandsConnectionString = new ConnectionString(configuration.GetConnectionString("DefaultConnection"));
            services.AddSingleton<IConnectionString>(commandsConnectionString);

        }
    }
}
