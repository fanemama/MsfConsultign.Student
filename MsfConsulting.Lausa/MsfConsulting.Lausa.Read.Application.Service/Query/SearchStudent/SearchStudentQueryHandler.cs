using MediatR;
using MsfConsulting.Lausa.Domain.Model.Search;
using MsfConsulting.Lausa.Shared;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dapper;

namespace MsfConsulting.Lausa.Read.Application.Service.Query
{
    public class SearchStudentQueryHandler : BaseQueryHandler, IRequestHandler<SearchStudentQuery, IEnumerable<LightStudent>>
    {
        public SearchStudentQueryHandler(IConnectionString connectionString) : base(connectionString)
        {
        }

        public async Task<IEnumerable<LightStudent>> Handle(SearchStudentQuery request, CancellationToken cancellationToken)
        {
            string WhereClause = request.ComputeWhereClause(out var dictionary);
            string sql = @$"
                    SELECT 
	                Students.Id, 
	                Students.FirstName, 
	                Students.LastName, 
	                Students.Email, 
	                Students.Phone,
	                Count(Enrollment.StudentId) AS NbrEnrollment,
                Count(Unenrollment.StudentId) AS NbrUnEnrollment
                FROM   Students Students 
                LEFT JOIN Enrollments Enrollment 
	                ON Students.Id = Enrollment.StudentId
                LEFT JOIN Unenrollments Unenrollment 
	                ON Students.Id = Unenrollment .StudentId
                {WhereClause} 
                GROUP BY 
	                Students.Id, Students.FirstName, Students.LastName, Students.Email, Students.Phone
                ORDER BY
	                Students.Id";

            using var connection = new MySqlConnection(_connectionString.Value);

            var parameters = new DynamicParameters(dictionary);

            return await connection.QueryAsync<LightStudent>(sql, parameters);
        }
    }
}
