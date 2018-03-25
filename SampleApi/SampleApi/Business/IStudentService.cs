using SampleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApi.Business
{
    public interface IStudentService
    {
        List<Student> GetList();
        bool InsertStudent(Student std);
    }
}