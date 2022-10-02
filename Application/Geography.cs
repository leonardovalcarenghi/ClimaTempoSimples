using ClimaTempoSimples.DTO.Geography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Application
{
    public class Geography
    {
        private readonly Infraestructure.Repository.Geography _repository;
        public Geography()
        {
            _repository = new Infraestructure.Repository.Geography();
        }

        /// <summary>
        /// Buscar lista de estados.
        /// </summary>
        /// <returns></returns>
        public List<StateDTO> GetStates()
        {
            List<StateDTO> states = _repository.GetStates();
            return states;
        }

        /// <summary>
        /// Buscar lista de cidades.
        /// </summary>
        /// <param name="stateId">Identificador do estado para retornar cidades do estado selecionado.</param>
        /// <returns></returns>
        public List<CityDTO> GetCities(int? stateID = null)
        {
            List<CityDTO> cities = _repository.GetCities(stateID);
            return cities;
        }

        /// <summary>
        /// Buscar uma cidade selecionada.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public CityDTO GetCity(int id)
        {
            CityDTO city = _repository.GetCity(id);
            return city;
        }

        /// <summary>
        /// Buscar um estado selecionado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StateDTO GetState(int id)
        {
            StateDTO state = _repository.GetState(id);
            return state;
        }



    }
}
