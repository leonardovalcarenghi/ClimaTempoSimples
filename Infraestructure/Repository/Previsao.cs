using ClimaTempoSimples.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Infraestructure.Repository
{
    public class Previsao
    {
        private static readonly string _connectionString = "Data Source=localhost; Initial Catalog=ClimaTempoSimples; Integrated Security=True";
     
        
        public List<ClimaDTO> ObterPrevisao(int cidade)
        {
            throw new NotImplementedException();
        }


    }
}
