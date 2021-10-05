using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Domain.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public IReadOnlyCollection<Enrollment> Enrollements => _enrollements.ToList();
        public IReadOnlyCollection<Unenrollment> Unenrollements => _unenrollements.ToList();

        private IList<Enrollment> _enrollements = new List<Enrollment>();
        public IList<Unenrollment> _unenrollements = new List<Unenrollment>();

        public  void UnEnroll(Enrollment enrollment, string comment)
        {
            var enrollmentToDelete = _enrollements.FirstOrDefault(x => x.Id == enrollment.Id);
            if (enrollmentToDelete is null) throw new ArgumentException($"Enrollment with the id ='{enrollment.Id}' not found for this student");

            _enrollements.Remove(enrollmentToDelete);

            var disenrollment = new Unenrollment(enrollment.Course, comment);
            _unenrollements.Add(disenrollment);
        }

        public  void Enroll(Course course, Grade grade=null)
        {
            var enrollmentToDelete = _enrollements.FirstOrDefault(x => x.Id == course.Id);
            if (enrollmentToDelete is not null) throw new ApplicationException($"the student is already enroll to the course ='{course.Label}'");
            
            var enrollment = new Enrollment(course, grade);
            _enrollements.Add(enrollment);
        }

    }
}
