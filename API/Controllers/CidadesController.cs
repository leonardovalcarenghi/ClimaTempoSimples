using ClimaTempoSimples.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [Route("cidades")]
    public class CidadesController : ApiController
    {

        private readonly Cidades _cidades;
        public CidadesController()
        {
            _cidades = new Cidades();
        }


        [HttpGet]
        public HttpResponseMessage Obter()
        {
            var result = _cidades.Obter();
            return Request.CreateResponse(HttpStatusCode.OK, new
            {
                Error = false,
                Result = result,
                Date = DateTime.Now
            });
        }

    }
}
