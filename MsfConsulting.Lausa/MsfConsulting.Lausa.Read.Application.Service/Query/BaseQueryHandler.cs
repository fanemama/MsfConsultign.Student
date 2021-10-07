using MsfConsulting.Lausa.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Read.Application.Service
{
    public abstract class BaseQueryHandler
    {
        protected readonly IConnectionString _connectionString;

        public BaseQueryHandler(IConnectionString connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
