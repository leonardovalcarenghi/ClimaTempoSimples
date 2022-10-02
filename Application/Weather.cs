using System;
using System.Collections.Generic;
using System.Globalization;
using ClimaTempoSimples.DTO;

namespace ClimaTempoSimples.Application
{
    public class Weather
    {

        private readonly Infraestructure.Repository.Weather _repository;
        public Weather()
        {
            _repository = new Infraestructure.Repository.Weather();
        }

        /// <summary>
        /// Buscar previsão do tempo para os próximos 7 dias para a cidade selecionada.
        /// </summary>
        /// <param name="cityId">Identificador da cidade.</param>
        /// <returns></returns>
        public List<WeatherDTO> Get(int cityId)
        {
            List<WeatherDTO> list = _repository.Get(cityId);
            if (list is null) { return null; }
            _setIcon(list);
            _setDayOfWeek(list);
            return list;
        }

        /// <summary>
        /// Buscar cidades com temperaturas mais quentes no dia de hoje.
        /// </summary>
        /// <returns></returns>
        public List<WeatherDTO> GetHottestCities(int total = 3)
        {
            List<WeatherDTO> list = _repository.GetHottestCities(total);
            if (list is null) { return null; }
            _setIcon(list);
            _setDayOfWeek(list);
            return list;
        }

        /// <summary>
        /// Buscar cidades com temperaturas mais frias no dia de hoje.
        /// </summary>
        /// <returns></returns>
        public List<WeatherDTO> GetColderCities(int total = 3)
        {
            List<WeatherDTO> list = _repository.GetColderCities(total);
            if (list is null) { return null; }
            _setIcon(list);
            _setDayOfWeek(list);
            return list;
        }

        #region Métodos Privados

        private void _setIcon(List<WeatherDTO> list)
        {
            string sunny = "bi bi-brightness-high-fill";            // Ensolarado
            string cloudy = "bi bi-clouds-fill";                    // Nublado
            string rainy = "bi bi-cloud-rain-heavy-fill";           // Chuvoso
            string stormy = "bi bi-cloud-lightning-rain-fill";      // Tempestuoso
            string unstable = "bi bi-cloud-sleet-fill";             // Instável

            foreach (WeatherDTO weather in list)
            {
                if (weather.Description == "Ensolarado") { weather.Icon = sunny; }
                if (weather.Description == "Nublado") { weather.Icon = cloudy; }
                if (weather.Description == "Chuvoso") { weather.Icon = rainy; }
                if (weather.Description == "Tempestuoso") { weather.Icon = stormy; }
                if (weather.Description == "Instavel") { weather.Icon = unstable; }
            }
        }

        private void _setDayOfWeek(List<WeatherDTO> list)
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            TextInfo textInfo = culture.TextInfo;
            foreach (WeatherDTO weather in list)
            {
                string dayOfWeek = culture.DateTimeFormat.GetDayName(weather.Date.DayOfWeek);
                weather.DayOfWeek = textInfo.ToTitleCase(dayOfWeek);
                if (weather.Date == DateTime.Today) { weather.DayOfWeek = "Hoje"; }
                if (weather.Date == DateTime.Today.AddDays(1)) { weather.DayOfWeek = "Amanhã"; }
            }
        }

        #endregion

    }
}
