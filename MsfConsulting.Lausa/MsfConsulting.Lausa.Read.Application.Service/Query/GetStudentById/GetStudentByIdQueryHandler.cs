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

namespace MsfConsulting.Lausa.Read.Application.Service.Query.GetStudentById
{
    public class GetStudentByIdQueryHandler : BaseQueryHandler, IRequestHandler<GetStudentByIdQuery,Student>
    {
        public GetStudentByIdQueryHandler(IConnectionString connectionString) : base(connectionString) { }

        public async Task<Student> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            string sql = @$"
                    SELECT 
	                    Students.Id, 
	                    Students.FirstName, 
	                    Students.LastName, 
	                    Students.Email, 
	                    Students.Phone,
	                    Enrollment.Id,
                                  EnrollmentGrade.Code as Grade,
                                   EnrollmentCourse.Code as Course,
                                   Enrollment.Date,
	                                Unenrollment.Id,
                                   CourseUnenrollment.Code as Course, 
                                   Unenrollment.Date,
                                  Unenrollment.Comment
                    FROM   Students Students 
                    LEFT JOIN Enrollments Enrollment 
	                    ON Students.Id = Enrollment.StudentId
                    LEFT JOIN Unenrollments Unenrollment 
	                    ON Students.Id = Unenrollment .StudentId
                    LEFT JOIN Courses EnrollmentCourse 
	                    ON EnrollmentCourse.Id = Enrollment.CourseId
                    LEFT JOIN Grades EnrollmentGrade
	                    ON EnrollmentGrade.Id = Enrollment.GradeId
                    LEFT JOIN Courses CourseUnenrollment 
	                    ON CourseUnenrollment.Id = Unenrollment.CourseId
                    WHERE 
	                    Students.Id = @Id";

            var studentDictionary = new Dictionary<int, Student>();

            using var connection = new MySqlConnection(_connectionString.Value);


            var students = await connection.QueryAsync<Student,Enrollment,Unenrollment, Student>(sql, 
                (student, enrollment, unenrollment) =>
                {
                    if (!studentDictionary.TryGetValue(student.Id, out var currentStudent))
                    {
                        currentStudent = student;
                        studentDictionary.Add(student.Id, student);
                    }
                   
                    if (enrollment is not null) currentStudent.Enrollments.Add(enrollment);
                    if (unenrollment is not null) currentStudent.Unenrollments.Add(unenrollment);
                    return currentStudent;
                }
                ,new { Id = request.Id });

            return students.FirstOrDefault();
        }
    }
}
