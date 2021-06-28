using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using OData6Demo.Api.Models;
using OData6Demo.Api.Services;

namespace OData6Demo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentsController(IStudentService studentService) =>
            this.studentService = studentService;

        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<Student>> GetAllStudents()
        {
            IQueryable<Student> retrievedStudents =
                this.studentService.RetrieveAllStudents();

            return Ok(retrievedStudents);
        }
    }
}
