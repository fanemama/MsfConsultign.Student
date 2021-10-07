using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Read.Application.Service.Query
{
    public static class SearchStudentQueryExtension
    {
        public static string ComputeWhereClause(this SearchStudentQuery request, out Dictionary<string, object> dictionary)
        {
            var conditions = new List<string>();
            dictionary = new Dictionary<string, object> { };

            if (!String.IsNullOrWhiteSpace(request.FirstName))
            {
                conditions.Add("Students.FirstName LIKE @FirstName");
                dictionary.Add("@FirstName", "%" + request.FirstName + "%");
            }
            if (!String.IsNullOrWhiteSpace(request.LastName))
            {
                conditions.Add("Students.LastName LIKE @LastName");
                dictionary.Add("@LastName", "%" + request.LastName + "%");
            }
            if (!String.IsNullOrWhiteSpace(request.Email))
            {
                conditions.Add("Students.Email LIKE @Email");
                dictionary.Add("@Email", "%" + request.Email + "%");
            }
            if (!String.IsNullOrWhiteSpace(request.Phone))
            {
                conditions.Add("Students.Phone LIKE @Phone");
                dictionary.Add("@Phone", "%" + request.Phone + "%");
            }

            if (!conditions.Any()) return string.Empty;

            return $"WHERE {string.Join("AND", conditions)}";
        }
    }
}
