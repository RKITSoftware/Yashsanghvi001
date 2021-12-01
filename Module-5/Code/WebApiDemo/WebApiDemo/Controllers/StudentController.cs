using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class StudentController : ApiController
    {

            [Route("api/student/names")]
            public IEnumerable<string> Get()
            {
                return new string[] { "student1", "student2" };
            }


}
}