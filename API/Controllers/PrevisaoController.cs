using ClimaTempoSimples.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{

   
    public class PrevisaoController : ApiController
    {

        private readonly Previsao _previsao;
        public PrevisaoController()
        {
            _previsao = new Previsao();
        }



        [HttpGet]
        [Route("previsao")]
        public HttpResponseMessage ObterPrevisao(int cidade)
        {
            var result = _previsao.ObterPrevisao(cidade);
            return Request.CreateResponse(HttpStatusCode.OK, new
            {
                Error = false,
                Result = result,
                Date = DateTime.Now
            });
        }


    }
}
