using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationDemo.Controllers
{
    public class PostExampleController : ApiController
    {
        //move this to models
        public class Student
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        
        public void Post(string id)
        {
            
        }

        [Route("find")]
        public Student Post()
        {
            //displaying a new student as the return 
            return new Student()
            {
                id = 1,
                name = "charlie"
            };

        }

        [Route("store")]
        public Student Post(Student stu)
        {
            //return a complex type
            //object binding will not be in the uri, but in the body

            return stu;
        }

        [HttpPost]
        //to get complex type from url 
        [Route("storeV3")]
        public Student Post2([FromUri] Student stu)
        {
            return stu;
        }

        [HttpPost]
        [Route("poststudent")]
        public Student PostStudent([FromBody] Student student)
        {
            return student;
        }

        //return a complex and primitive type together 
        [Route("storeV2")]
        public Dictionary<int, Student> Post(Student stu, int id)
        {
            Dictionary<int, Student> dict = new Dictionary<int, Student>();
            dict.Add(id, stu);

            return dict;

            //primitive type => url
            //complex type => body
        }




    }
}
