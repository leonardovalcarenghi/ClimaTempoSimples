using ClimaTempoSimples.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [Route("estados")]
    public class EstadosController : ApiController
    {

        private readonly Estados _estados;
        public EstadosController()
        {
            _estados = new Estados();
        }


        [HttpGet]
        public HttpResponseMessage Obter()
        {
            var result = _estados.Obter();
            return Request.CreateResponse(HttpStatusCode.OK, new
            {
                Error = false,
                Result = result,
                Date = DateTime.Now
            });
        }
    }
}
