using SampleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApi
{
    public interface IUserService
    {
        List<user> GetList();
    }
}