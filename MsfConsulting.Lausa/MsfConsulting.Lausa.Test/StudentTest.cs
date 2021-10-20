using MsfConsulting.Lausa.Domain.Model;
using System;
using Xunit;

namespace MsfConsulting.Lausa.Test
{
    public class StudentTest
    {
        [Fact]
        public void EnrollTwiceSameCourseShouldThrowException()
        {
            var student = new Student();
            var course = new Course { Id = 1, Code = "E", Label = "English" };

            student.Enroll(course);
            var ex = Assert.Throws<ApplicationException>(() => student.Enroll(course));
            Assert.Equal($"the student is already enroll to the course ='{course.Label}'", ex.Message);
        }

        [Fact]
        public void EnrollShouldThrowException()
        {
            var student = new Student();
            var course = new Course { Id = 1, Code = "E", Label = "English" };

            student.Enroll(course);
            Assert.Equal(1, student.Enrollements.Count);
        }
    }
}
