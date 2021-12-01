using Dapper;
using MediatR;
using MsfConsulting.Lausa.Domain.Model.Search;
using MsfConsulting.Lausa.Dto;
using MsfConsulting.Lausa.Shared;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Read.Application.Service.Query.GetAllStudentLocation
{
    public class GetAllStudentLocationHandler : BaseQueryHandler, IRequestHandler<GetAllStudentLocationQuery, IEnumerable<StudentLocation>>
    {
        public GetAllStudentLocationHandler(IConnectionString connectionString) : base(connectionString) { }

        public async Task<IEnumerable<StudentLocation>> Handle(GetAllStudentLocationQuery request, CancellationToken cancellationToken)
        {
            string sql = @$"
                        SELECT 
                            Students.Id,
                            Students.FirstName,
                            Students.LastName,
                            Students.Email,
                            Students.Phone,
                            Location.Id,
                            Location.Latitude,
                            Location.Speed,
                            Location.Longitude,
                            Location.Elevation,
                            Location.Heading,
                            Location. DATE,
                            Location.StudentId AS StudentId
                        FROM Students Students 
                        LEFT JOIN Locations Location ON Students.LiveLocationId = Location.Id ";

            var studentDictionary = new Dictionary<int, StudentLocation>();

            using var connection = new MySqlConnection(_connectionString.Value);


            var students = await connection.QueryAsync<StudentLocation, Location, StudentLocation>(sql, 
                (student, location) =>
                {
                    if (!studentDictionary.TryGetValue(student.Id, out var currentStudent))
                    {
                        currentStudent = student;
                        studentDictionary.Add(student.Id, student);
                    }

                    currentStudent.LiveLocation = location;
                    return currentStudent;
                });

            return students.ToList();
        }
    }
}
