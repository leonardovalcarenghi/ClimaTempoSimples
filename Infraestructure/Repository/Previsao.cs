using ClimaTempoSimples.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Infraestructure.Repository
{
    public class Previsao
    {

        private readonly string _connectionString = "Data Source=localhost; Initial Catalog=ClimaTempoSimples; Integrated Security=True";


        public List<ClimaDTO> Obter(int cidade)
        {
            List<ClimaDTO> list = null;
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(Queries.Previsao.Obter, connection) { CommandType = CommandType.Text };
            try
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("@CidadeId", cidade));
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (list is null) { list = new List<ClimaDTO>(); }
                        list.Add(new ClimaDTO
                        {
                            Id = Convert.ToInt32(reader["Id"].ToString()),
                            TemperaturaMaxima = double.Parse(reader["TemperaturaMaxima"].ToString()),
                            TemperaturaMinima = double.Parse(reader["TemperaturaMinima"].ToString()),
                            Clima = reader["Clima"].ToString(),
                            DataPrevisao = DateTime.Parse(reader["DataPrevisao"].ToString()),
                            UF = reader["UF"].ToString(),
                            Cidade = reader["Cidade"].ToString()
                        });
                    }
                    reader.Close();
                }
                return list;
            }
            catch (SqlException sqlEx) { throw; }
            catch (Exception ex) { throw; }
            finally { connection.Close(); }
        }


    }
}
