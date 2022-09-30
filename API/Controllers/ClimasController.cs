using ClimaTempoSimples.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("climas")]
    public class ClimasController : ApiController
    {

        private readonly Climas _climas;
        public ClimasController()
        {
            _climas = new Climas();
        }


        [HttpGet]
        [Route("mais-quentes")]
        public HttpResponseMessage ObterMaisQuentes(int total = 3)
        {
            var result = _climas.ObterMaisQuentes(total);
            return Request.CreateResponse(HttpStatusCode.OK, new
            {
                Error = false,
                Result = result,
                Date = DateTime.Now
            });
        }

        [HttpGet]
        [Route("mais-frias")]
        public HttpResponseMessage ObterMaisFrias(int total = 3)
        {
            var result = _climas.ObterMaisFrias(total);
            return Request.CreateResponse(HttpStatusCode.OK, new
            {
                Error = false,
                Result = result,
                Date = DateTime.Now
            });
        }



    }
}
