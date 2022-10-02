using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.DTO
{
    public class WeatherDTO
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string StateAbbreviation { get; set; }
        public DateTime Date { get; set; }
        public string DayOfWeek { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public double Max { get; set; }
        public double Min { get; set; }
    }
}
