using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Application
{
    public static class InsertDefault
    {
        public static void PrepararBancoDeDados(bool reset)
        {
            Infraestructure.Repository.InsertDefault.PrepararBancoDeDados(reset);
            Infraestructure.Repository.InsertDefault.AdicionarClimas();
        }

    }
}
