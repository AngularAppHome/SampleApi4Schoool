using SampleApi.Business;
using SampleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleApi.Controllers
{
    public class StudentsController : ApiController
    {
        IStudentService stdService = new StudentService();
        public IHttpActionResult GetStudentList()
        {
            return Ok(stdService.GetList().ToList());
        }
        [HttpPost]
        public IHttpActionResult SaveStudent(Student std)
        {
            stdService.InsertStudent(std);
            return Ok();
        }
    }
}
