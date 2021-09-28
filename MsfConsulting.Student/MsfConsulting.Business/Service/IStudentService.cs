using MsfConsulting.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Business.Service
{
    public interface IStudentService
    {
        public void Register(Student student);

        public void Unregister(int id);

        public void Enroll(int id, Enrollment enrollment);

        public void Unenroll(int id, Enrollment enrollment);

        public void UpdatePersonalInfo(StudentPersonalInfo studentPersonalInfo);
    }
}
