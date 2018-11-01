using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Cors;
using VIznegration.Models;

namespace VIznegration.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class NodesController : ApiController
    {
        // GET api/values
        public dynamic Get()
        {
            var file = System.IO.File.ReadAllText(@"C:\Users\Lee\Source\Repos\VIznegration\VIznegration\casa.json");
            var json = System.Web.Helpers.Json.Decode(file);
            //var nodes = new Node[2];
            //nodes[0] = new Node()
            //{
            //    Key = "1",
            //    Description = "testing",
            //    Category = "Operation",
            //    Name = "test1"
            //};

            //nodes[1] = new Node()
            //{
            //    Key = "2",
            //    Description = "testing 2",
            //    Category = "Operation",
            //    Name = "test2"
            //};

            return json;
        }

        //// GET api/values/5
        //public Node Get(string id)
        //{
        //    var node = Get().Where(n => n.Key == id).FirstOrDefault();
        //    return node;
        //}

        // POST api/values
        [HttpPost]
        public void Post([FromBody]object value)
        {
            //var jsonString = System.Web.Helpers.Json.Encode(value);
            var fileName = DateTime.Now.ToString().Replace(" ", "");
            fileName = fileName.Replace("/", "");
            fileName = fileName.Replace(":", "");
            System.IO.File.WriteAllText(@"C:\Users\Lee\Source\Repos\VIznegration\VIznegration\" + fileName + ".json", value.ToString());
        }

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
