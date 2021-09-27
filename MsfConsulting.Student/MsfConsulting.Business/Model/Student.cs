using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Business.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public IReadOnlyCollection<Enrollment> Enrollements => _enrollements.ToList();
        public IReadOnlyCollection<UnEnrollment> UnEnrollements => _unEnrollements.ToList();

        private IList<Enrollment> _enrollements { get; set; }
        public IList<UnEnrollment> _unEnrollements { get; set; }

        public virtual void UnEnroll(Enrollment enrollment, string comment)
        {
            var enrollmentToDelete = _enrollements.FirstOrDefault(x => x.Id == enrollment.Id);
            if (enrollmentToDelete is null) throw new ArgumentException($"not Enrollment with theb id ='{enrollment.Id}' found for student");

            _enrollements.Remove(enrollmentToDelete);

            var disenrollment = new UnEnrollment(enrollment.Course, comment);
            _unEnrollements.Add(disenrollment);
        }

        public virtual void Enroll(Course course, Grade grade)
        {

            var enrollment = new Enrollment(course, grade);
            _enrollements.Add(enrollment);
        }

    }
}
