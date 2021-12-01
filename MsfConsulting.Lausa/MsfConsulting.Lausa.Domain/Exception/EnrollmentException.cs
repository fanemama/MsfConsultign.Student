using System;
using System.Runtime.Serialization;

namespace MsfConsulting.Lausa.Domain.Model
{
    [Serializable]
    public  class EnrollmentException : Exception
    {
        public EnrollmentException() { }
        public EnrollmentException(string? message) : base(message) { }
        public EnrollmentException(string? message, System.Exception? innerException) : base(message, innerException) { }
    }
}