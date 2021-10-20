using AutoMoq;
using Moq;
using MsfConsulting.Lausa.Application.Service.Command;
using MsfConsulting.Lausa.Domain.Model;
using MsfConsulting.Lausa.Domain.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MsfConsulting.Lausa.Test
{
    public class EnrollCommandHandlerTest
    {
        private AutoMoqer _mocker;

        [Fact]
        public async Task EnrollToCourseThatDoNotExistShouldThrowException()
        {
            _mocker = new AutoMoqer();

            var student = new Student() { Id = 1 };
            var course = new Course { Id = 1, Code = "E", Label = "English" };
            var enrollCommand = new EnrollCommand(student.Id) { Course = course.Code };

            _mocker.GetMock<IRepository<Student>>()
                .Setup(p => p.GetById(1))
                .Returns(Task.FromResult(student));

            _mocker.GetMock<IReferentialRepository<Course>>()
                .Setup(p => p.GetByCode(It.IsAny<string>()))
                .Returns(Task.FromResult((Course)null));

            var _command = _mocker.Create<EnrollCommandHandler>();
            var ex = await Assert.ThrowsAsync<ArgumentException>(() =>  _command.Handle(enrollCommand, new CancellationToken(false)));
            Assert.Equal($"Course with code '{enrollCommand.Course}' not foumd", ex.Message);
        }

        [Fact]
        public async Task EnrollWithGradeThatDoNotExistShouldThrowException()
        {
            _mocker = new AutoMoqer();

            var student = new Student() { Id = 1 };
            var course = new Course { Id = 1, Code = "E", Label = "English" };
            var grade = new Grade { Id = 1, Code = "A", Label = "A" };
            var enrollCommand = new EnrollCommand(student.Id) { Course = course.Code, Grade= grade.Code };

            _mocker.GetMock<IRepository<Student>>()
                .Setup(p => p.GetById(1))
                .Returns(Task.FromResult(student));

            _mocker.GetMock<IReferentialRepository<Course>>()
                .Setup(p => p.GetByCode(course.Code))
                .Returns(Task.FromResult(course));

            _mocker.GetMock<IReferentialRepository<Grade>>()
               .Setup(p => p.GetByCode(It.IsAny<string>()))
               .Returns(Task.FromResult((Grade)null));

            var _command = _mocker.Create<EnrollCommandHandler>();
            var ex = await Assert.ThrowsAsync<ArgumentException>(() => _command.Handle(enrollCommand, new CancellationToken(false)));
            Assert.Equal($"Grade with code '{enrollCommand.Grade}' not foumd", ex.Message);
        }

        [Fact]
        public async Task EnrollShouldSuccess()
        {
            _mocker = new AutoMoqer();

            var student = new Student() { Id = 1 };
            var course = new Course { Id = 1, Code = "E", Label = "English" };
            var grade = new Grade { Id = 1, Code = "A", Label = "A" };

            var enrollCommand = new EnrollCommand(student.Id) { Course = course.Code, Grade = grade.Code };

          

            _mocker.GetMock<IRepository<Student>>()
                .Setup(p => p.GetById(1))
                .Returns(Task.FromResult(student));

            _mocker.GetMock<IReferentialRepository<Course>>()
                .Setup(p => p.GetByCode(course.Code))
                .Returns(Task.FromResult(course));

            _mocker.GetMock<IReferentialRepository<Grade>>()
               .Setup(p => p.GetByCode(grade.Code))
               .Returns(Task.FromResult(grade));


            _mocker.GetMock<IRepository<Student>>()
               .Setup(p => p.Update(student))
                .Verifiable();

            _mocker.GetMock<IUnitOfWork>()
              .Setup(p => p.SaveChanges())
              .Verifiable(); ;

            var _command = _mocker.Create<EnrollCommandHandler>();
            var result = await _command.Handle(enrollCommand, new CancellationToken(false));
            Assert.Equal(enrollCommand.Grade, result.Grade.Code);
            Assert.Equal(enrollCommand.Course, result.Course.Code);
        }
    }
}
