using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.DTO
{
    public class ClimaDTO
    {
        public int Id { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public DateTime DataPrevisao { get; set; }
        public string Clima { get; set; }
        public double TemperaturaMinima { get; set; }
        public double TemperaturaMaxima { get; set; }
    }
}
