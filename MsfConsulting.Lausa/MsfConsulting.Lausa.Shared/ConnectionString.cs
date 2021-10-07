using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Shared
{
    public class ConnectionString : IConnectionString
    {
        public string Value { get; }
        public ConnectionString(string value)
        {
            Value = value;
        }
    }
}
