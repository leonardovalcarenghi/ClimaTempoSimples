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

        /// <summary>
        /// Obter lista de cidades.
        /// </summary>
        /// <returns></returns>
        public List<CidadeDTO> Obter()
        {
            List<CidadeDTO> list = new List<CidadeDTO>();

            list.Add(new CidadeDTO { Id = 1, EstadoId = 1, Nome = "Porto Alegre" });
            list.Add(new CidadeDTO { Id = 2, EstadoId = 1, Nome = "Gramado" });
            list.Add(new CidadeDTO { Id = 3, EstadoId = 1, Nome = "Caxias do Sul" });

            list.Add(new CidadeDTO { Id = 4, EstadoId = 2, Nome = "São Paulo (Capital)" });
            list.Add(new CidadeDTO { Id = 5, EstadoId = 2, Nome = "São Bernardo do campo" });
            list.Add(new CidadeDTO { Id = 6, EstadoId = 2, Nome = "Guarulhos" });

            list.Add(new CidadeDTO { Id = 7, EstadoId = 2, Nome = "Rio de Janeiro (Capital)" });
            list.Add(new CidadeDTO { Id = 8, EstadoId = 2, Nome = "Niterói" });
            list.Add(new CidadeDTO { Id = 9, EstadoId = 2, Nome = "Petrópolis" });

            return list;
        }

    }
}
