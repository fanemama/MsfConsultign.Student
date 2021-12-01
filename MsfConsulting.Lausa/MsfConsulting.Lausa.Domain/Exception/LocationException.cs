using System;
using System.Runtime.Serialization;

namespace MsfConsulting.Lausa.Domain.Model
{
    [Serializable]
    public  class LocationException : Exception
    {
        public LocationException() { }
        public LocationException(string? message) : base(message) { }
        public LocationException(string? message, System.Exception? innerException) : base(message, innerException) { }
    }
}