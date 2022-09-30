using ClimaTempoSimples.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Application
{
    public class Estados
    {
        public List<EstadoDTO> Obter()
        {
            List<EstadoDTO> list = new List<EstadoDTO>();
            list.Add(new EstadoDTO { Id = 1, Nome = "Rio Grande do Sul", UF = "RS" });
            list.Add(new EstadoDTO { Id = 2, Nome = "São Paulo", UF = "SP" });
            list.Add(new EstadoDTO { Id = 3, Nome = "Rio de Janeiro", UF = "RJ" });
            return list;
        }
    }
}
