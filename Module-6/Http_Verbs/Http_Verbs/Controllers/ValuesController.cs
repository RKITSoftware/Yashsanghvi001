using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Http_Verbs.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        //create a list of books
        static List<string> obj_studnet = new List<string>()
        {
            "Ram","Shyam","Laxman"
        };

        // GET api/values
        //This gives result to GET method without parameter
        [Route("")]
        public IEnumerable<string> Get()
        {
            return obj_studnet;
        }

        // GET api/values/5
        [Route("{int:id}")]
        public string Get(int id)
        {
            return obj_studnet[id];
        }

        // POST api/values
        //used to create new item
        [Route("")]
        public void Post([FromBody] string value)
        {
            obj_studnet.Add(value);
        }

        // PUT api/values/5
        //used to update an item: "id" is what we update with "value"
        [Route("int:id")]
        public void Put(int id, [FromBody] string value)
        {
            obj_studnet[id] = value;
        }

        // DELETE api/values/5
        //used to remove an item
        [Route("int:id")]
        [HttpDelete]
        public void Delete(int id)
        {
            obj_studnet.RemoveAt(id);
        }
    }
}
