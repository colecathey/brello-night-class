using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace Brello.Controllers
{
    public class BoardApiController : ApiController
    {
        // GET: api/BoardApi
        public ActionResult Get()
        {
            //JsonSerializer 
            List<string> list_of_strings = new List<string>();
            list_of_strings.Add("Hello");
            list_of_strings.Add("Goodbye");
            JsonResult response = new JsonResult();
            //response.
            response.Data = list_of_strings;
            response.ContentType = "application/json";
            return response;
        }
            
        /*
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // GET: api/BoardApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BoardApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BoardApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BoardApi/5
        public void Delete(int id)
        {
        }
    }
}
