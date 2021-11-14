using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static WebApplicationDemo.Controllers.PostExampleController;

namespace WebApplicationDemo.Controllers
{
    public class PutPatchExampleController : ApiController
    {
        List<Student> studentsList = new List<Student>();

        [HttpPatch]
        public List<Student> PatchStudentName(int id, string name)
        {
            Student existStudent = studentsList.Where(x => x.id == id).FirstOrDefault();
            if (existStudent == null)
            {
                return null;
            }

            studentsList.Remove(existStudent);
            existStudent.name = name;
            studentsList.Add(existStudent);

            return studentsList;
        }

        [HttpPut]
        public List<Student> PutStudentName(Student student)
        {
            Student existStudent = studentsList.Where(x => x.id == student.id).FirstOrDefault();
            if (existStudent == null)
            {
                return null;
            }

            studentsList.Remove(existStudent);
            studentsList.Add(existStudent);

            return studentsList;
        }

    }
}
