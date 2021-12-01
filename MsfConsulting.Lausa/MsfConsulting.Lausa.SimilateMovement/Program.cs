using MsfConsulting.Lausa.Dto;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;

namespace MsfConsulting.Lausa.SimilateMovement
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {

            Console.WriteLine("starting moving Students!!! :-)");
            List<StudentLocation> Students = await GetStudentLocations();


            _ = Task.Run(async () =>
            {

                do
                {
                    foreach (var Student in Students)
                    {
                        await Move(Student);
                    }

                    await Task.Delay(1000);
                } while (true);

            });

            Console.ReadKey();
        }

        private static async Task<List<StudentLocation>> GetStudentLocations()
        {
            using HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://localhost:44344/Student/get-all-student-location");
            return await response.Content.ReadAsAsync<List<StudentLocation>>();
        }

        private static async Task<Uri> Move(StudentLocation Student)
        {
            Random random = new Random();
            var oldLatitude = Student.LiveLocation.Latitude;
            var oldLongitude = Student.LiveLocation.Longitude;

            var moveLatitude = (Double)random.Next(0, 9999) / 10000000;
            var moveLongitude = (Double)random.Next(0, 9999) / 10000000;

            if (Student.LiveLocation.Id % 2 == 0)
            {
                Student.LiveLocation.Latitude += moveLatitude;
                Student.LiveLocation.Longitude += moveLongitude;
            }
            else
            {
                Student.LiveLocation.Latitude -= moveLatitude;
                Student.LiveLocation.Longitude -= moveLongitude;
            }

            Student.LiveLocation.Heading = ComputeHeading(oldLatitude, oldLongitude, Student.LiveLocation.Latitude, Student.LiveLocation.Longitude);

            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsJsonAsync($"https://localhost:44304/Student/set-live-location/{Student.Id}",
                BuildSetLocation(Student));

            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        private static double ComputeHeading(double latitude1, double longitude1, double latitude2, double longitude2)
        {
            double DeltaLongitude = (longitude2 - longitude1);
            double x = Math.Cos(latitude2) * Math.Sin(DeltaLongitude);
            double y = Math.Cos(latitude1) * Math.Sin(latitude2) - Math.Sin(latitude1) * Math.Cos(latitude2) * Math.Cos(DeltaLongitude);
            var radiansheading = Math.Atan2(x, y);
            return radiansheading * 180 / Math.PI;
        }

        private static SetLocation BuildSetLocation(StudentLocation student)
        {
            return new SetLocation
            {
                Longitude = student.LiveLocation.Longitude,
                Latitude = student.LiveLocation.Latitude,
                Speed = new Random().Next(80, 220),
                Elevation = 1608.637939453125,
                Heading = student.LiveLocation.Heading,
                Date = DateTime.Now
            };
        }
    }
}
