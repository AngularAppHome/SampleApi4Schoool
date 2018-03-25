using SampleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApi
{
    public class UserService:IUserService
    {
        SchoolDbEntities db = new SchoolDbEntities();

        public List<user> GetList()
        {
            return db.users.ToList();
        }
    }
}