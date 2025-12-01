using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Practica1.UI.Controllers
{
    public class ReservasAPIController : ApiController
    {
        // GET: api/ReservasAPI
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ReservasAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ReservasAPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ReservasAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ReservasAPI/5
        public void Delete(int id)
        {
        }
    }
}
