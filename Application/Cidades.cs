using ClimaTempoSimples.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Application
{
    public class Cidades
    {
        private readonly Infraestructure.Repository.Cidades _repository;

        public Cidades()
        {
            _repository = new Infraestructure.Repository.Cidades();
        }

        /// <summary>
        /// Obter lista de cidades.
        /// </summary>
        /// <returns></returns>
        public List<CidadeDTO> Obter()
        {
            List<CidadeDTO> list = _repository.Obter();
            return list;
        }

    }
}
