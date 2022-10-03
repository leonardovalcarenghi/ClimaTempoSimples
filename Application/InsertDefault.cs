using ClimaTempoSimples.DTO;
using ClimaTempoSimples.DTO.Geography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Application
{
    public static class InsertDefault
    {
        public static void PrepararBancoDeDados(bool reset)
        {
            Infraestructure.Repository.InsertDefault.PrepararBancoDeDados(reset);
            Infraestructure.Repository.InsertDefault.AdicionarClimas();



            Infraestructure.Repository.Geography geography = new Infraestructure.Repository.Geography();
            List<CityDTO> cities = geography.GetCities();
            foreach (CityDTO city in cities)
            {

                WeatherDTO weather = GenerateRandomWeather();

            }

        }



        #region Métodos Privados

        static WeatherDTO GenerateRandomWeather()
        {
            Random random = new Random();
            int min = random.Next(0, 40);
            int max = random.Next(min, min + 12);

            int i = random.Next(0, 4);
            string[] descriptions = { "Instavel", "Tempestuoso", "Chuvoso", "Nublado", "Ensolarado" };
            string description = descriptions[i];
     
            WeatherDTO weather = new WeatherDTO
            {
                Min = min,
                Max = max
            };
            return weather;
        }


        #endregion

    }
}
