using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationDemo.Controllers
{
    public class HelloWorldController : ApiController
    {
        public IEnumerable<string> Get()
        {
            IList<string> list = new List<string>();
            list.Add("Hello");
            list.Add("World");

            return list;
        }

        public string Get(int id)
        {
            return "Parameterised get method" + id;
        }

        public string Get(int id, string name)
        {
            return "Parameterised get method. id: " + id + "name: " +name;
        }

    }
}
