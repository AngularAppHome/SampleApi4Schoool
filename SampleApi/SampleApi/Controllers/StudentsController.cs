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
            var isSave = stdService.InsertStudent(std);
            if (isSave == true)
                return Ok();
            return BadRequest();
        }
        [HttpPut]
        public IHttpActionResult UpdateStudent(Student std)
        {
            var isUpdate = stdService.UpdateStudent(std);
            if (isUpdate == true)
                return Ok();
            return BadRequest();
        }
        [HttpDelete]
        public IHttpActionResult RemoveStudent(int? id)
        {
            var isDelete = stdService.DeleteStudent(id);
            if (isDelete == true)
                return Ok();
            return BadRequest();
        }
    }
}
