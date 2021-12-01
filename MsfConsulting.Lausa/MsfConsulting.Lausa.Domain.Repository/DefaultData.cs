using Microsoft.EntityFrameworkCore;
using MsfConsulting.Lausa.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Domain.Repository
{
    public static class DefaultData
    {
        public static void Build(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Model.Location>().HasData(
                new Location { Id = 1, Longitude = 5.0259003, Latitude = 40.5110708, Speed = 150, Date = DateTime.Now },
                new Location { Id = 2, Longitude = 6.6258003, Latitude = 46.5110708, Speed = 150, Date = DateTime.Now },
                new Location { Id = 3, Longitude = 8.1257003, Latitude = 41.5110708, Speed = 150, Date = DateTime.Now },
                new Location { Id = 4, Longitude = 15.2256003, Latitude = 42.5110708, Speed = 150, Date = DateTime.Now },
                new Location { Id = 5, Longitude = 10.3255003, Latitude = 43.5110708, Speed = 150, Date = DateTime.Now },
                new Location { Id = 6, Longitude = 7.4254003, Latitude = 44.5110708, Speed = 150, Date = DateTime.Now },
                new Location { Id = 7, Longitude = 2.5253003, Latitude = 45.5110708, Speed = 150, Date = DateTime.Now },
                new Location { Id = 8, Longitude = 3.6252003, Latitude = 46.5110708, Speed = 150, Date = DateTime.Now },
                new Location { Id = 9, Longitude = 4.7251003, Latitude = 47.5110708, Speed = 150, Date = DateTime.Now },
                new Location { Id = 10, Longitude = 5.8250003, Latitude = 48.5110708, Speed = 150, Date = DateTime.Now },
                new Location { Id = 11, Longitude = 3.9248003, Latitude = 49.5110708, Speed = 150, Date = DateTime.Now },
                new Location { Id = 12, Longitude = 6.0241003, Latitude = 42.5110708, Speed = 150, Date = DateTime.Now },
                new Location { Id = 13, Longitude = 6.4257003, Latitude = 46.5110708, Speed = 150, Date = DateTime.Now },
                new Location { Id = 14, Longitude = 6.5259003, Latitude = 46.5110708, Speed = 150, Date = DateTime.Now },
                new Location { Id = 15, Longitude = 6.6560003, Latitude = 46.5110708, Speed = 150, Date = DateTime.Now });

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1,  LastName = "LastName1",  LiveLocationId = 1,  Email = "toto@titu.fr", FirstName = "BMW"},
                new Student { Id = 2,  LastName = "LastName2",  LiveLocationId = 2,  Email = "toto@titu.fr", FirstName = "RENAULT" },
                new Student { Id = 3,  LastName = "LastName3",  LiveLocationId = 3,  Email = "toto@titu.fr", FirstName = "MERCEDES"},
                new Student { Id = 4,  LastName = "LastName4",  LiveLocationId = 4,  Email = "toto@titu.fr", FirstName = "SUZUKI"},
                new Student { Id = 5,  LastName = "LastName5",  LiveLocationId = 5,  Email = "toto@titu.fr", FirstName = "TOYOTA"},
                new Student { Id = 6,  LastName = "LastName6",  LiveLocationId = 6,  Email = "toto@titu.fr", FirstName = "PEUGEOT"},
                new Student { Id = 7,  LastName = "LastName7",  LiveLocationId = 7,  Email = "toto@titu.fr", FirstName = "PORSCHE"},
                new Student { Id = 8,  LastName = "LastName8",  LiveLocationId = 8,  Email = "toto@titu.fr", FirstName = "MERCEDES"},
                new Student { Id = 9,  LastName = "LastName9",  LiveLocationId = 9,  Email = "toto@titu.fr", FirstName = "OPEL"},
                new Student { Id = 10, LastName = "LastName10", LiveLocationId = 10, Email = "toto@titu.fr", FirstName = "TOYOTA"},
                new Student { Id = 11, LastName = "LastName11", LiveLocationId = 11, Email = "toto@titu.fr", FirstName = "CITROEN"},
                new Student { Id = 12, LastName = "LastName12", LiveLocationId = 12, Email = "toto@titu.fr", FirstName = "PEUGEOT"},
                new Student { Id = 13, LastName = "LastName13", LiveLocationId = 13, Email = "toto@titu.fr", FirstName = "BMW"},
                new Student { Id = 14, LastName = "LastName14", LiveLocationId = 14, Email = "toto@titu.fr", FirstName = "RENAULT" },
                new Student { Id = 15, LastName = "LastName15", LiveLocationId = 15, Email = "toto@titu.fr", FirstName = "MERCEDES"});

        }
    }
}
