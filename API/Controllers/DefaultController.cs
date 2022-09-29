using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class DefaultController : ApiController
    {

        public HttpResponseMessage Ok(object result)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new
            {
                error = false,
                result = result,
                date = DateTime.Now
            });
        }
    }
}
