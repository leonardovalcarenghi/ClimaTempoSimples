using ClimaTempoSimples.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Application
{
    public class Previsao
    {
        private readonly Infraestructure.Repository.Previsao _repository;
        public Previsao()
        {
            _repository = new Infraestructure.Repository.Previsao();
        }


        public List<ClimaDTO> ObterPrevisao(int cidade)
        {
            List<ClimaDTO> list = _repository.ObterPrevisao(cidade);
            return list;
        }
    }
}
