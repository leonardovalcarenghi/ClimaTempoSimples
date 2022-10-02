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
        private readonly Infraestructure.Repository.Climas _repository;
        public Climas()
        {
            _repository = new Infraestructure.Repository.Climas();
        }

        /// <summary>
        /// Obter lista de cidades mais quentes.
        /// </summary>
        /// <param name="total">Número total de resultados.</param>
        /// <returns></returns>
        public List<ClimaDTO> ObterMaisQuentes(int total = 3)
        {
            List<ClimaDTO> list = _repository.ObterMaisQuentes(total);      
            return list;
        }


        /// <summary>
        /// Obter lista de cidades mais frias.
        /// </summary>
        /// <param name="total">Número total de resultados.</param>
        /// <returns></returns>
        public List<ClimaDTO> ObterMaisFrias(int total = 3)
        {
            List<ClimaDTO> list = _repository.ObterMaisFrias(total);
            return list;
        }


    }
}
