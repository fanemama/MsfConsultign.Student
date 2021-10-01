
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

using MsfConsulting.Lausa.Data.Repository;

namespace MsfConsulting.Lausa.Database.Migrations
{
    public class LausaDbContextFactory : IDesignTimeDbContextFactory<LausaDbContext>
    {
        public LausaDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", true)
                 .Build();

            var builder = new DbContextOptionsBuilder<LausaDbContext>();

            var connectionString = configuration
                        .GetConnectionString("DefaultConnection");

            builder.UseMySQL(connectionString,
                        x => x.MigrationsAssembly(typeof(LausaDbContextFactory).Assembly.FullName));



            return new LausaDbContext(builder.Options);
        }

        
    }
}
