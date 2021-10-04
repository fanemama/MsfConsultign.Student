﻿using MsfConsulting.Lausa.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Domain.Service
{
    public interface ICourseService
    {
        Task<Course> GetByCode(string code);
    }
}
