using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
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

        public bool UpdateStudent(Student std)
        {
            db.Entry(std).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }
        public bool DeleteStudent (int? id)
        {
            var itemToRemove = db.Students.SingleOrDefault(x => x.Id == id); //returns a single item.

            if (itemToRemove != null)
            {
                db.Students.Remove(itemToRemove);
                db.SaveChanges();
                return true;
            }
            else
            return false;
        }
    }
}