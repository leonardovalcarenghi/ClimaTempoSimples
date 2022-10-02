using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClimaTempoSimples.API.Controllers
{
    public class DefaultController : ApiController
    {

        public HttpResponseMessage OK(object result, string message = "")
        {
            return Request.CreateResponse(HttpStatusCode.OK, new
            {
                Error = false,
                Result = result,
                Message = message,
                Date = DateTime.Now
            });
        }

        public HttpResponseMessage Error(Exception exception)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new
            {
                Error = true,
                Message = exception.Message,
                Date = DateTime.Now
            });
        }


    }
}
