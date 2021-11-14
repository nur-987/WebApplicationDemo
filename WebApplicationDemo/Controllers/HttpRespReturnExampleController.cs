using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationDemo.Controllers
{
    public class HttpRespReturnExampleController : ApiController
    {

        public HttpResponseMessage Post1(int id, int id1)
        {
            HttpResponseMessage message = new HttpResponseMessage();
            return message;
        }

        public HttpResponseMessage Post2(int id, int id1)
        {
            HttpResponseMessage message = new HttpResponseMessage();
            if (id == 100)
            {
                message.StatusCode = HttpStatusCode.OK;
            }
            else
            {
                message.StatusCode = HttpStatusCode.BadRequest;
            }

            return message;
        }

    }
}
