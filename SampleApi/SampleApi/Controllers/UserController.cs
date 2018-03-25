using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleApi.Controllers
{
    public class UserController : ApiController
    {
        IUserService userService = new UserService();
        public IHttpActionResult GetUserList()
        {
            return Ok(userService.GetList().ToList());
        }
    }
}
