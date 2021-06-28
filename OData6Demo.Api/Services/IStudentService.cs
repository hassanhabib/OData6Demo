using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OData6Demo.Api.Models;

namespace OData6Demo.Api.Services
{
    public interface IStudentService
    {
        IQueryable<Student> RetrieveAllStudents();
    }
}
