using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace _2WebAPIAndDBWithEntity.Controllers
{
    //[EnableCorsAttribute("*", "*", "*")] //enable cors on controller level
    public class ValuesController : ApiController
    {
        // GET api/values
        //[DisableCors] //disbale cors on controller method level
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
            
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
