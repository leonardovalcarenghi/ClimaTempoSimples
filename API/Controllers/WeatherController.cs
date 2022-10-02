using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClimaTempoSimples.API.Controllers
{
    [RoutePrefix("weather")]
    public class WeatherController : DefaultController
    {
        private readonly Application.Weather _weather;
        public WeatherController()
        {
            _weather = new Application.Weather();   
        }

        [HttpGet]
        [Route("~/weather")]
        public HttpResponseMessage Get(int city)
        {
            try
            {
                var result = _weather.Get(city);
                return OK(result);
            }
            catch (Exception exception) { return Error(exception); }
        }

        [HttpGet]
        [Route("hottest-cities")]
        public HttpResponseMessage GetHottestCities(int total)
        {
            try
            {
                var result = _weather.GetHottestCities(total);
                return OK(result);
            }
            catch (Exception exception) { return Error(exception); }
        }

        [HttpGet]
        [Route("colder-cities")]
        public HttpResponseMessage GetColderCities(int total)
        {
            try
            {
                var result = _weather.GetColderCities(total);
                return OK(result);
            }
            catch (Exception exception) { return Error(exception); }
        }



    }
}
