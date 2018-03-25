using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleApi.Models;

namespace SampleApi.Business
{
    public class StudentService : IStudentService
    {
        SchoolDbEntities db = new SchoolDbEntities();
        public List<Student> GetList()
        {
            return db.Students.ToList();
        }

        public bool InsertStudent(Student std)
        {
            db.Students.Add(std);
            db.SaveChanges();
            return true;
        }
    }
}