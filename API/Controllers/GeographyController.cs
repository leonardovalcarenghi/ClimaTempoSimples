using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClimaTempoSimples.API.Controllers
{

    [RoutePrefix("geography")]
    public class GeographyController : DefaultController
    {

        private readonly Application.Geography _geography;
        public GeographyController()
        {
            _geography = new Application.Geography();
        }

        [HttpGet]
        [Route("cities")]
        public HttpResponseMessage GetCities()
        {
            try
            {
                var result = _geography.GetCities();
                return OK(result);
            }
            catch (Exception exception) { return Error(exception); }
        }

        [HttpGet]
        [Route("states")]
        public HttpResponseMessage GetStates()
        {
            try
            {
                var result = _geography.GetStates();
                return OK(result);
            }
            catch (Exception exception) { return Error(exception); }
        }

    }
}
