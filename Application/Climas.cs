using ClimaTempoSimples.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Application
{
    public class Climas
    {

        /// <summary>
        /// Obter lista de cidades mais quentes.
        /// </summary>
        /// <param name="total">Número total de resultados.</param>
        /// <returns></returns>
        public List<ClimaDTO> ObterMaisQuentes(int total = 3)
        {
            List<ClimaDTO> list = new List<ClimaDTO>();
            list.Add(new ClimaDTO
            {
                Id = 1,
                EstadoId = 1,
                Nome = "Porto Alegre",
                Clima = "Ensolarado",
                DataPrevisao = DateTime.Now,
                TemperaturaMaxima = 36.8,
                TemperaturaMinima = 22.8
            });

            list.Add(new ClimaDTO
            {
                Id = 2,
                EstadoId = 1,
                Nome = "Gramado",
                Clima = "Ensolarado",
                DataPrevisao = DateTime.Now,
                TemperaturaMaxima = 32.1,
                TemperaturaMinima = 24.8
            });

            return list;
        }


        /// <summary>
        /// Obter lista de cidades mais frias.
        /// </summary>
        /// <param name="total">Número total de resultados.</param>
        /// <returns></returns>
        public List<ClimaDTO> ObterMaisFrias(int total = 3)
        {
            List<ClimaDTO> list = new List<ClimaDTO>();
            list.Add(new ClimaDTO
            {
                Id = 1,
                EstadoId = 2,
                Nome = "São Paulo (Capital)",
                Clima = "Chuvoso",
                DataPrevisao = DateTime.Now,
                TemperaturaMaxima = 18.7,
                TemperaturaMinima = 12.9
            });

            list.Add(new ClimaDTO
            {
                Id = 7,
                EstadoId = 3,
                Nome = "Rio de Janeiro (Capital)",
                Clima = "Ensolarado",
                DataPrevisao = DateTime.Now,
                TemperaturaMaxima = 14.9,
                TemperaturaMinima = 08.2
            });

            return list;
        }


    }
}
