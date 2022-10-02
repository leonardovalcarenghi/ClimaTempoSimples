using ClimaTempoSimples.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
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


        public List<ClimaDTO> Obter(int cidade)
        {
            List<ClimaDTO> list = _repository.Obter(cidade);
            if (list is null) { return null; }
            foreach (ClimaDTO clima in list)
            {
                CultureInfo culture = new CultureInfo("pt-BR");
                string dayOfWeek = culture.DateTimeFormat.GetDayName(clima.DataPrevisao.DayOfWeek);
                clima.DiaDaSemana = culture.TextInfo.ToTitleCase(dayOfWeek);
            }
            return list;
        }
    }
}
