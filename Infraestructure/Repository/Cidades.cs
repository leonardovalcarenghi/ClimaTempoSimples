using ClimaTempoSimples.DTO;
using ClimaTempoSimples.Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Infraestructure.Repository
{
    public class Cidades
    {
        public Cidades()
        {

        }

        public List<CidadeDTO> Obter()
        {


            CidadeContext context = new CidadeContext();

            //context.Cidades.Select(cidade => new )

            List<CidadeDTO> list = new List<CidadeDTO>();

            list.Add(new CidadeDTO { Id = 1, EstadoId = 1, Nome = "Porto Alegre" });
            list.Add(new CidadeDTO { Id = 2, EstadoId = 1, Nome = "Gramado" });
            list.Add(new CidadeDTO { Id = 3, EstadoId = 1, Nome = "Caxias do Sul" });

            list.Add(new CidadeDTO { Id = 4, EstadoId = 2, Nome = "São Paulo (Capital)" });
            list.Add(new CidadeDTO { Id = 5, EstadoId = 2, Nome = "São Bernardo do campo" });
            list.Add(new CidadeDTO { Id = 6, EstadoId = 2, Nome = "Guarulhos" });

            list.Add(new CidadeDTO { Id = 7, EstadoId = 3, Nome = "Rio de Janeiro (Capital)" });
            list.Add(new CidadeDTO { Id = 8, EstadoId = 3, Nome = "Niterói" });
            list.Add(new CidadeDTO { Id = 9, EstadoId = 3, Nome = "Petrópolis" });

            return list;
        }

    }
}
