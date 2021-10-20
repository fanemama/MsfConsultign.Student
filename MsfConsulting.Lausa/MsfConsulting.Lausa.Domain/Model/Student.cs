using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Domain.Model
{
    public class Student: IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public IList<Enrollment> Enrollements { get; private set; } = new List<Enrollment>();
        public IList<Unenrollment> Unenrollements { get; private set; } = new List<Unenrollment>();

        public void UnEnroll(Enrollment enrollment, string comment)
        {
            if (comment is null) throw new ArgumentException($"To unEnroll comment must not be provided");

            var enrollmentToDelete = Enrollements.FirstOrDefault(x => x.Id == enrollment.Id);
            if (enrollmentToDelete is null) throw new ArgumentException($"Enrollment with the id ('{enrollment.Id}') not found");

            Enrollements.Remove(enrollmentToDelete);

            var disenrollment = new Unenrollment(enrollment.Course, comment);
            Unenrollements.Add(disenrollment);
        }

        public Enrollment Enroll(Course course, Grade grade = null)
        {
            var existingEnrollment = Enrollements.FirstOrDefault(x => x.Course.Id == course.Id);
            if (existingEnrollment is not null) throw new ApplicationException($"the student is already enroll to the course ='{course.Label}'");

            var enrollment = new Enrollment(course, grade);
            Enrollements.Add(enrollment);

            return enrollment;
        }
    }
}
