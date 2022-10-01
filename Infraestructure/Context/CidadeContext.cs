using ClimaTempoSimples.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Infraestructure.Context
{
    public class CidadeContext : DbContext
    {
        public DbSet<CidadeDTO> Cidades { get; set; }
    }
}
