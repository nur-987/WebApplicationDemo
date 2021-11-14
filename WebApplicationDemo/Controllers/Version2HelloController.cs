using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplicationDemo.Controllers
{
    /// <summary>
    /// routing through attributes.
    /// need to comment out routing provided in WebApiConfig.cs
    ///
    /// HttpGet through attributes.
    /// Does not need the method to be named as "get"
    /// </summary>
    /// 
    [RoutePrefix("api/Version2Hello")]
    public class Version2HelloController:ApiController
    {
        [Route("")]
        public IEnumerable<string> Get()
        {
            IList<string> list = new List<string>();
            list.Add("Hello");
            list.Add("World");

            return list;
        }

        //[Route("")]
        //public string Get(int id)
        //{
        //    return "Parameterised get method" + id;
        //}

        [Route("{id:int}/{name}")]
        public string Get(int id, string name)
        {
            return "Parameterised get method. id: " + id + "name: " + name;
        }

        [Route("Find/{id:range(50,100)}")]
        public string Get(int id)
        {
            return "Parameterised get method" + id;
        }

        [HttpGet]
        [Route("get")]
        public string DisplayId(int id)
        {
            return "http get attribute. id: " + id;
        }

    }
}